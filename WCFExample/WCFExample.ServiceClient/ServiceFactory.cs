using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;
using WCFExamle.ServiceInterface;

namespace WCFExample.ServiceClient
{
    internal class ServiceFactory
    {
        public ICalculator GetCalculatorClient(string remotingAddress)
        {
            if(string.IsNullOrEmpty(remotingAddress))
            {
                return null;
            }
            try
            {
                return new CalculatorClient(this.GetInitBinding(), new EndpointAddress(remotingAddress));
            }
            catch
            {
                return null;
            }
        }

        public ICalculator GetCalculatorClient(string remotingAddress, Binding binding)
        {
            if (string.IsNullOrEmpty(remotingAddress))
            {
                return null;
            }
            try
            {
                return new CalculatorClient(binding, new EndpointAddress(remotingAddress));
            }
            catch
            {
                return null;
            }
        }

        private BasicHttpBinding GetInitBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxBufferSize = 0x27100000;
            binding.MaxReceivedMessageSize = 0x27100000L;
            binding.MaxBufferPoolSize = 0x138800000L;
            XmlDictionaryReaderQuotas quotas = new XmlDictionaryReaderQuotas();
            quotas.MaxStringContentLength = 0x4e20000;
            binding.ReaderQuotas = quotas;
            return binding;
        }
    }
}
