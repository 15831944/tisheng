using System.ServiceModel;
namespace WCFExamle.ServiceInterface
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        decimal Add(decimal a, decimal b);
    }
}
