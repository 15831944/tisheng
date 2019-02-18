using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockInterface;
using System.ServiceModel;
using StockBll;

namespace StockService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, AddressFilterMode = AddressFilterMode.Any)]
    public class DuplexService : IDuplexService
    {
        DuplexBLL db = new DuplexBLL();
        public string RegisterClient()
        {
            IClientCallBack callback = OperationContext.Current.GetCallbackChannel<IClientCallBack>();
            return db.RegisterClient(callback.SendMessage);
        }

        public void TestClient(string str)
        {
            string token = OperationContext.Current.Channel.InputSession.Id;
            DuplexBLL.ClientLst.ToList().ForEach(m => {
                m.Value.Invoke(str);
            });
        }
    }
}
