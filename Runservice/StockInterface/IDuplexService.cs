using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace StockInterface
{
    [ServiceContract(CallbackContract =typeof(IClientCallBack))]
      public interface IDuplexService
    {
        [OperationContract]
        string RegisterClient();

        [OperationContract(IsOneWay = true)]
        void TestClient(string str);
    }
}
