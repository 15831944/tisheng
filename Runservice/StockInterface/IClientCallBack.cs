using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace StockInterface
{
    public interface IClientCallBack
    {

        [OperationContract(IsOneWay = true)]
        void SendMessage(string str);
    }
}
