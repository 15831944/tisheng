using CMST.Storage.Client.Proxy;
using CMST.Storage.Client.Proxy.DataModelProxy;
using CMST.Storage.Client.Proxy.UIDisplayProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.Client.UIMatch
{
    public class UIOperate
    {

        UIDisplayProxyClient MyUIDisplayProxy = null;
        LocalClientProxy MyLcp = null;
        public UIOperate(LocalClientProxy.PROTOCAL protocol, string address)
        {
            MyLcp = new LocalClientProxy(protocol, address);
            MyUIDisplayProxy = MyLcp.GetUIDisplayProxy();
        }

        public System.Data.DataSet GetColInfo(string name, string type)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            string jsonResult = MyUIDisplayProxy.GetUICol(name, type);
            fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonResult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                DataSet ds = JsonConvert.DeserializeObject<DataSet>(fi.Result.ToString());
                return ds;
            }
            else
            {
                return null;
            }
        }

        public DataSet GetTableStruct(string tablename)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            string jsonResult = MyUIDisplayProxy.GetUITableStruct(tablename);
            fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonResult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                DataSet ds = JsonConvert.DeserializeObject<DataSet>(fi.Result.ToString());
                return ds;
            }
            else
            {
                return null;
            }
        }
    }
}
