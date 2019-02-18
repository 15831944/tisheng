using System.ServiceModel;
using System.ServiceModel.Channels;
using WCFExamle.ServiceInterface;
namespace WCFExample.ServiceClient
{
    internal class CalculatorClient : ClientBase<ICalculator>,ICalculator
    {
        public CalculatorClient(Binding binding, EndpointAddress remoteAddress):base(binding,remoteAddress)
        { 
        }

        public  decimal Add(decimal a,decimal b)
        {
           return base.Channel.Add(a, b);
        }
    }
}
