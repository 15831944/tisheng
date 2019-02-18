using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using StockService;
using StockInterface;

namespace Runservice
{
  public class WcfServiceStock
    {
        private static List<ServiceHost> serviceHosts;
        private string Service_ip;
        private int Service_Port;
        private string httpStr;
        private string TcpStr;
        private string wshttpStr;
        private string service_dll;
        public WcfServiceStock(string serviceip, int serviceport, string servicedll)
        {
            serviceHosts = new List<ServiceHost>();
            this.Service_ip = serviceip;
            this.Service_Port = serviceport;
            this.httpStr = "http://" + Service_ip + ":" + Service_Port + "/";
            this.TcpStr = "net.tcp://" + Service_ip + ":" + (Service_Port + 1) + "/";
            this.wshttpStr = "http://" + Service_ip + ":" + (Service_Port + 2) + "/";
            this.service_dll = servicedll;
        }
        public bool RunHostBothHttpAndTcpProtocol(out string StrResult)
        {
            try
            {
                StrResult = "";
                serviceHosts.Clear();
                string TypeFullName = this.GetType().FullName;
                Type[] allclass = Assembly.Load(service_dll).GetTypes().Where(n => n.IsPublic == true && n.FullName != TypeFullName &&n.FullName.Contains(service_dll) &&! n.Name.Contains("DuplexService")).ToArray<Type>();
                foreach (var acitem in allclass)
                {
                    Type[] allinterface = acitem.GetInterfaces().Where(n => n.IsPublic == true && n.GetCustomAttributes(false).OfType<ServiceContractAttribute>().Any()).ToArray<Type>();
                    if (allinterface.Length==0)
                    {
                        continue;
                    }
                    Uri httpuri = new Uri(httpStr + acitem.Name);
                    Uri tcpuri = new Uri(TcpStr + acitem.Name);
                    Uri wshttpuri = new Uri(wshttpStr + acitem.Name);
                    ServiceHost sssh = new ServiceHost(acitem, new Uri[] { wshttpuri, tcpuri });

                    WebHttpBinding webhttpBInding = new WebHttpBinding(WebHttpSecurityMode.TransportCredentialOnly);
                    webhttpBInding.CrossDomainScriptAccessEnabled = true;

                    NetTcpBinding tcpBingding= GetNetTcpBinding();

                    WSHttpBinding wshttpbinding= GetWSHttpBinding();
                    EndpointAddress httpepa = new EndpointAddress(httpuri);
                    EndpointAddress tcpepa = new EndpointAddress(tcpuri);
                    EndpointAddress wshttpepa = new EndpointAddress(wshttpuri);
                    ServiceMetadataBehavior smbhhtp = new ServiceMetadataBehavior();
                    smbhhtp.HttpGetEnabled = true;
                    smbhhtp.HttpGetUrl = wshttpuri;
                    sssh.Description.Behaviors.Add(smbhhtp);
                    ServiceDebugBehavior sdb = sssh.Description.Behaviors.Find<ServiceDebugBehavior>();
                    sdb.IncludeExceptionDetailInFaults = true;
                    if (sdb==null)
                    {
                        sdb = new ServiceDebugBehavior();
                        sssh.Description.Behaviors.Add(sdb);
                        
                    }
                    sssh.Description.Name = acitem.Name;
                    serviceHosts.Add(sssh);

                    foreach (var aiItem in allinterface)
                    {
                        ContractDescription contract = ContractDescription.GetContract(aiItem.UnderlyingSystemType);
                        contract.Name = acitem.Name + "Proxy";
                        WebHttpEndpoint httpesp = new WebHttpEndpoint(contract, httpepa);
                        httpesp.CrossDomainScriptAccessEnabled = true;
                        webhttpBInding.CloseTimeout = new TimeSpan(0, 1, 0);
                        webhttpBInding.OpenTimeout = new TimeSpan(0, 1, 0);
                        webhttpBInding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                        webhttpBInding.SendTimeout = new TimeSpan(0, 1, 0);
                        webhttpBInding.BypassProxyOnLocal = false;

                        webhttpBInding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
                        webhttpBInding.MaxBufferPoolSize = 524288;
                        webhttpBInding.MaxReceivedMessageSize = 2147483647;
                        webhttpBInding.UseDefaultWebProxy = false;
                        webhttpBInding.AllowCookies = false;
                        webhttpBInding.ReaderQuotas.MaxDepth = 32;
                        webhttpBInding.ReaderQuotas.MaxStringContentLength = 8192;
                        webhttpBInding.ReaderQuotas.MaxNameTableCharCount = 16384;
                        webhttpBInding.ReaderQuotas.MaxBytesPerRead = 4096;
                        webhttpBInding.ReaderQuotas.MaxArrayLength = 16384;
                        WebHttpBehavior whb = new WebHttpBehavior();
                        whb.AutomaticFormatSelectionEnabled = true;
                        whb.FaultExceptionEnabled = true;
                        whb.HelpEnabled = true;
                        whb.DefaultOutgoingRequestFormat = WebMessageFormat.Json;
                        httpesp.EndpointBehaviors.Clear();
                        httpesp.EndpointBehaviors.Add(whb);
                        httpesp.EndpointBehaviors.Add(new WebScriptEnablingBehavior());
                        httpesp.Binding = webhttpBInding;


                        ServiceEndpoint tcpsep = new ServiceEndpoint(contract, tcpBingding, tcpepa);
                        ServiceEndpoint wshttpsep = new ServiceEndpoint(contract, wshttpbinding, wshttpepa);

                        sssh.AddServiceEndpoint(httpesp);
                        sssh.AddServiceEndpoint(tcpsep);
                        sssh.AddServiceEndpoint(wshttpsep);
                        sssh.Open();

                    }
                   


                }
                RunDulplex();
                return true;

            }
            catch (Exception ex)
            {

                string str = "";
                CloseAllHosts(ref str);
                StrResult = ex.Message.ToString();
                serviceHosts.Clear();
                return false;
            }
        }
        public bool CloseAllHosts(ref string strResult)
        {
            try
            {
                if (serviceHosts != null)
                {
                    foreach (var sh in serviceHosts)
                    {
                        if (sh.State != CommunicationState.Closed)
                        {

                            sh.Abort();
                            sh.Close();

                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                strResult = ex.Message.ToLower();
                return false;
            }
        }
        public void RunDulplex()
        {
            ServiceHost shDuplex = new ServiceHost(typeof(DuplexService));
            NetTcpBinding nhbDuplex = new NetTcpBinding(SecurityMode.None);
            Uri addressDuplex = new Uri(TcpStr + "DuplexService/");
            shDuplex.AddServiceEndpoint(typeof(IDuplexService), nhbDuplex, addressDuplex);
            ServiceMetadataBehavior smbDuplex = shDuplex.Description.Behaviors.Find<ServiceMetadataBehavior>();

            if (smbDuplex == null)
            {
                smbDuplex = new ServiceMetadataBehavior();
                smbDuplex.HttpGetEnabled = true;
                smbDuplex.HttpGetUrl = new Uri(wshttpStr + "DuplexService/");
                shDuplex.Description.Behaviors.Add(smbDuplex);
            }

            serviceHosts.Add(shDuplex);
            shDuplex.Open();
        }

        private NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding tcpBinding = new NetTcpBinding(SecurityMode.None);
            tcpBinding.SendTimeout = new TimeSpan(0, 10, 0);
            tcpBinding.TransferMode = TransferMode.Streamed;
            tcpBinding.ReceiveTimeout = new TimeSpan(0, 30, 0);
            tcpBinding.ReliableSession.InactivityTimeout = new TimeSpan(0, 30, 0);
            tcpBinding.MaxReceivedMessageSize = 2147483647;
            tcpBinding.MaxBufferSize = 2147483647;
            tcpBinding.MaxBufferPoolSize = 2147483647;
            tcpBinding.ReaderQuotas.MaxDepth = 2147483647;
            tcpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
            tcpBinding.ReaderQuotas.MaxArrayLength = 2147483647;
            return tcpBinding;
        }
        private WSHttpBinding GetWSHttpBinding()
        {
            WSHttpBinding wshttpBinding = new WSHttpBinding(SecurityMode.None);
            wshttpBinding.SendTimeout = new TimeSpan(0, 10, 0);
            wshttpBinding.MaxBufferPoolSize = 2147483647;
            wshttpBinding.MaxReceivedMessageSize = 2147483647;
            wshttpBinding.ReaderQuotas.MaxDepth = 2147483647;
            wshttpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
            return wshttpBinding;
        }

    }
}
