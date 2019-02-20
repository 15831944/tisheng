using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CMST.Storage.Client.Proxy.BaseManageProxy;
using CMST.Storage.Client.Proxy.ProductManageProxy;
using CMST.Storage.Client.Proxy.UIDisplayProxy;
using CMST.Storage.Client.Proxy.CustomerManageProxy;
using System.ServiceModel.Channels;
using System.Security.Cryptography.X509Certificates;
using CMST.Storage.Client.Proxy.InStoreManageProxy;
using CMST.Storage.Client.Proxy.OutStoreManageProxy;
using CMST.Storage.Client.Proxy.CarManageProxy;
using CMST.Storage.Client.Proxy.TranspositionManageProxy;
using CMST.Storage.Client.Proxy.SpecialBusinessManageProxy;
using CMST.Storage.Client.Proxy.ChargeManageProxy;
using CMST.Storage.Client.Proxy.AccountServiceProxy;
using CMST.Storage.Client.Proxy.OutStorageManageServiceProxy;
using CMST.Storage.Client.Proxy.MachingManageProxy;
using CMST.Storage.Client.Proxy.SkuServiceProxy;
using CMST.Storage.Client.Proxy.AdjustManageProxy;
using CMST.Storage.Client.Proxy.LoginManageProxy;
using CMST.Storage.WCFInspector;
using CMST.Storage.Client.Proxy.ReportManageProxy;
using CMST.Storage.Client.Proxy.StocktakingManageProxy;

namespace CMST.Storage.Client.Proxy
{
    public class LocalClientProxy
    {
        private static PROTOCAL _protocol;
        private static string _address;
        static BaseManageProxyClient MyBaseManageProxy = null;
        static UIDisplayProxyClient MyUIDisplayProxy = null;
        static CustomerManageProxyClient MyCustomerManageProxy = null;
        static ProductManageProxyClient ProductManageProxy = null;
        static InStoreManageProxyClient InStoreManageProxy = null;
        static OutStoreManageProxyClient OutStoreManageProxy = null;
        static CarManageProxyClient CarManageProxy = null;
        static TranspositionManageProxyClient TranspositionManageProxy = null;
        static SpecialBusinessManageProxyClient SpecialBusinessManageProxy = null;
        static ChargeManageProxyClient ChargeManageProxy = null;
        static AccountProxyClient AccountServiceProxy= null;
        static OutStorageManageProxyClient OutStorageManageProxy = null;
        static MachingManageProxyClient MachingManageProxy = null;
        static SKUProxyClient SkuServiceProxy = null;
        static AdjustManageProxyClient AdjustManageProxy = null;
        static LoginManageProxyClient LoginManageProxy = null;
        static ReportManageProxyClient ReportManageProxy = null;
        static StocktakingManageProxyClient StocktakingManageProxy = null;
        public enum PROTOCAL
        {
            NET_TCP = 0,
            WSHTTP = 1,
        }
        public LocalClientProxy(PROTOCAL protocol, string address)
        {
           _protocol = protocol;
           _address = address;
        }
        private NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding tcpBinding = new NetTcpBinding(SecurityMode.None);
            tcpBinding.SendTimeout = new TimeSpan(0, 10, 0);
            tcpBinding.ReceiveTimeout = new TimeSpan(0, 30, 0);
            tcpBinding.ReliableSession.InactivityTimeout = new TimeSpan(0, 30, 0);
            tcpBinding.MaxReceivedMessageSize = 2147483647;
            tcpBinding.MaxBufferSize = 2147483647;
            tcpBinding.MaxBufferPoolSize = 2147483647;
            tcpBinding.ReaderQuotas.MaxDepth = 2147483647;
            tcpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
            tcpBinding.TransferMode = TransferMode.Streamed;
            tcpBinding.ReaderQuotas.MaxArrayLength = 2147483647;
            return tcpBinding;
        }
        private NetTcpBinding GetNetTcpBindingDuplex()
        {
            NetTcpBinding nettcpBinding = new NetTcpBinding(SecurityMode.None);
            nettcpBinding.SendTimeout = new TimeSpan(0, 10, 0);
            nettcpBinding.ReceiveTimeout = new TimeSpan(0, 30, 0);
            nettcpBinding.ReliableSession.InactivityTimeout = new TimeSpan(0, 30, 0);
            nettcpBinding.MaxReceivedMessageSize = 2147483647;
            nettcpBinding.MaxBufferSize = 2147483647;
            nettcpBinding.MaxBufferPoolSize = 2147483647;
            nettcpBinding.ReaderQuotas.MaxDepth = 2147483647;
            nettcpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
            nettcpBinding.TransferMode = TransferMode.Buffered;
            return nettcpBinding;
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

     
       public Binding GetBinding()
        {
            if (_protocol == PROTOCAL.NET_TCP)
            {
                return GetNetTcpBinding();
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                return GetWSHttpBinding();
            }
            return null;
        }

        public BaseManageProxyClient GetBaseManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.BASEMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.BASEMANAGE_WSHTTP, _address);
            }
            if (MyBaseManageProxy != null)
            {
                if (MyBaseManageProxy.Endpoint.Address.ToString() == url)
                    return MyBaseManageProxy;
            }
            MyBaseManageProxy = new BaseManageProxyClient(GetBinding(), new EndpointAddress(url));
            MyBaseManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return MyBaseManageProxy;
        }

      
        public UIDisplayProxyClient GetUIDisplayProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.UIDISPLAY_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.UIDISPLAY_WSHTTP, _address);
            }
            if (MyUIDisplayProxy != null)
            {
                if (MyUIDisplayProxy.Endpoint.Address.ToString() == url)
                    return MyUIDisplayProxy;
            }
            MyUIDisplayProxy = new UIDisplayProxyClient(GetBinding(), new EndpointAddress(url));
            MyUIDisplayProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return MyUIDisplayProxy;
        }

      
        public CustomerManageProxyClient GetCustomerManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.CUSTOMERMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.CUSTOMERMANAGE_WSHTTP, _address);
            }
            if (MyCustomerManageProxy != null)
            {
                if (MyCustomerManageProxy.Endpoint.Address.ToString() == url)
                    return MyCustomerManageProxy;
            }
            MyCustomerManageProxy = new CustomerManageProxyClient(GetBinding(), new EndpointAddress(url));
            MyCustomerManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return MyCustomerManageProxy;
        }

       
        public ProductManageProxyClient GetProductManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.PRODUCTMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.PRODUCTMANAGE_WSHTTP, _address);
            }
            if (ProductManageProxy != null)
            {
                if (ProductManageProxy.Endpoint.Address.ToString() == url)
                    return ProductManageProxy;
            }
            ProductManageProxy = new ProductManageProxyClient(GetBinding(), new EndpointAddress(url));
            ProductManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return ProductManageProxy;
        }
        public InStoreManageProxyClient GetInStoreManageProxy() {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.INSTOREMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.INSTOREMANAGE_WSHTTP, _address);
            }
            if (InStoreManageProxy != null)
            {
                if (InStoreManageProxy.Endpoint.Address.ToString() == url)
                    return InStoreManageProxy;
            }
            InStoreManageProxy = new InStoreManageProxyClient(GetBinding(), new EndpointAddress(url));
            InStoreManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return InStoreManageProxy;
        }
        public OutStoreManageProxyClient GetOutStoreManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.OUTSTOREMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.OUTSTOREMANAGE_WSHTTP, _address);
            }
            if (OutStoreManageProxy != null)
            {
                if (OutStoreManageProxy.Endpoint.Address.ToString() == url)
                    return OutStoreManageProxy;
            }
            OutStoreManageProxy = new OutStoreManageProxyClient(GetBinding(), new EndpointAddress(url));

            OutStoreManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return OutStoreManageProxy;
        }
        public CarManageProxyClient GetCarManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.CARMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.CARMANAGE_WSHTTP, _address);
            }
            if (CarManageProxy != null)
            {
                if (CarManageProxy.Endpoint.Address.ToString() == url)
                    return CarManageProxy;
            }
            CarManageProxy = new CarManageProxyClient(GetBinding(), new EndpointAddress(url));

            CarManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return CarManageProxy;
        }
        public TranspositionManageProxyClient GetTranspositionManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.TRANSPOSITIONMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.TRANSPOSITIONMANAGE_WSHTTP, _address);
            }
            if (TranspositionManageProxy != null)
            {
                if (TranspositionManageProxy.Endpoint.Address.ToString() == url)
                    return TranspositionManageProxy;
            }
            TranspositionManageProxy = new TranspositionManageProxyClient(GetBinding(), new EndpointAddress(url));
            TranspositionManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return TranspositionManageProxy;
        }
        public SpecialBusinessManageProxyClient GetSpecialBusinessManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.SPECIALBUSINESSMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.SPECIALBUSINESSMANAGE_WSHTTP, _address);
            }
            if (SpecialBusinessManageProxy != null)
            {
                if (SpecialBusinessManageProxy.Endpoint.Address.ToString() == url)
                    return SpecialBusinessManageProxy;
            }
            SpecialBusinessManageProxy = new SpecialBusinessManageProxyClient(GetBinding(), new EndpointAddress(url));

            SpecialBusinessManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return SpecialBusinessManageProxy;
        }

        public ChargeManageProxyClient GetChargeManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.CHARGEMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.CHARGEMANAGE_WSHTTP, _address);
            }
            if (ChargeManageProxy != null)
            {
                if (ChargeManageProxy.Endpoint.Address.ToString() == url)
                    return ChargeManageProxy;
            }
            ChargeManageProxy = new ChargeManageProxyClient(GetBinding(), new EndpointAddress(url));
            ChargeManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return ChargeManageProxy;
        }

        public AccountProxyClient GetAccountProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.ACCOUNTSERVICE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.ACCOUNTSERVICE_WSHTTP, _address);
            }
            if (AccountServiceProxy != null)
            {
                if (AccountServiceProxy.Endpoint.Address.ToString() == url)
                    return AccountServiceProxy;
            }
            AccountServiceProxy = new AccountProxyClient(GetBinding(), new EndpointAddress(url));
            AccountServiceProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return AccountServiceProxy;
        }

        public OutStorageManageProxyClient GetOutStorageManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.OUTSTORAGEMANAGESERVICE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.OUTSTORAGEMANAGESERVICE_WSHTTP, _address);
            }
            if (OutStorageManageProxy != null)
            {
                if (OutStorageManageProxy.Endpoint.Address.ToString() == url)
                    return OutStorageManageProxy;
            }
            OutStorageManageProxy = new OutStorageManageProxyClient(GetBinding(), new EndpointAddress(url));
            OutStorageManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return OutStorageManageProxy;
        }

        public MachingManageProxyClient GetMachingManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.MACHINGMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.MACHINGMANAGE_WSHTTP, _address);
            }
            if (MachingManageProxy != null)
            {
                if (MachingManageProxy.Endpoint.Address.ToString() == url)
                    return MachingManageProxy;
            }
            MachingManageProxy = new MachingManageProxyClient(GetBinding(), new EndpointAddress(url));
            MachingManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return MachingManageProxy;
        }
        public SKUProxyClient GetSKUProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.SKUSERVICE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.SKUSERVICE_WSHTTP, _address);
            }
            if (SkuServiceProxy != null)
            {
                if (SkuServiceProxy.Endpoint.Address.ToString() == url)
                    return SkuServiceProxy;
            }
            SkuServiceProxy = new SKUProxyClient(GetBinding(), new EndpointAddress(url));
            SkuServiceProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return SkuServiceProxy;
        }
        public AdjustManageProxyClient GetAdjustManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.ADJUSTMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.ADJUSTMANAGE_WSHTTP, _address);
            }
            if (AdjustManageProxy != null)
            {
                if (AdjustManageProxy.Endpoint.Address.ToString() == url)
                    return AdjustManageProxy;
            }
            AdjustManageProxy = new AdjustManageProxyClient(GetBinding(), new EndpointAddress(url));
            AdjustManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return AdjustManageProxy;
        }
        public LoginManageProxyClient GetLoginManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.LOGINMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.LOGINMANAGE_WSHTTP, _address);
            }
            if (LoginManageProxy != null)
            {
                if (LoginManageProxy.Endpoint.Address.ToString() == url)
                    return LoginManageProxy;
            }
            LoginManageProxy = new LoginManageProxyClient(GetBinding(), new EndpointAddress(url));
            LoginManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return LoginManageProxy;
        }
        public ReportManageProxyClient GetReportManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.REPORTMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.REPORTMANAGE_WSHTTP, _address);
            }
            if (ReportManageProxy != null)
            {
                if (ReportManageProxy.Endpoint.Address.ToString() == url)
                    return ReportManageProxy;
            }
            ReportManageProxy = new ReportManageProxyClient(GetBinding(), new EndpointAddress(url));
            ReportManageProxy.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
            return ReportManageProxy;
        }
        public StocktakingManageProxyClient GetStocktakingManageProxy()
        {
            string url = "";
            if (_protocol == PROTOCAL.NET_TCP)
            {
                url = string.Format(ServiceAddress.STOCKTAKINGMANAGE_NETTCP, _address);
            }
            else if (_protocol == PROTOCAL.WSHTTP)
            {
                url = string.Format(ServiceAddress.STOCKTAKINGMANAGE_WSHTTP, _address);
            }
            if (StocktakingManageProxy != null)
            {
                if (StocktakingManageProxy.Endpoint.Address.ToString() == url)
                    return StocktakingManageProxy;
            }
            StocktakingManageProxy = new StocktakingManageProxyClient(GetBinding(), new EndpointAddress(url));
            return StocktakingManageProxy;
        }
    }
}
