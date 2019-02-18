using System.ServiceModel.Channels;  
using WCFExamle.ServiceInterface;

namespace WCFExample.ServiceClient
{
    public class ServiceProxy
    {
        private ICalculator m_ICalculator;
        public ServiceProxy(string remotingAddress)
        {
            m_ICalculator = new ServiceFactory().GetCalculatorClient(remotingAddress);
        }

        public ServiceProxy(string remotingAddress,Binding binding)
        {
            m_ICalculator = new ServiceFactory().GetCalculatorClient(remotingAddress, binding);
        }

        public decimal Add(decimal a,decimal b)
        {
            return m_ICalculator.Add(a, b);
        }
    }
}
