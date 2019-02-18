using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace StockBll
{
    public class DuplexBLL
    {
        public delegate void CallBack(string str);
        private static Dictionary<string, CallBack> clientList;
        public static Dictionary<string, CallBack> ClientLst
        {
            get
            {
                if (clientList == null)
                {
                    clientList = new Dictionary<string, CallBack>();

                }
                return clientList;
            }
        }
        public string RegisterClient(CallBack cb)
        {
            string userID = OperationContext.Current.IncomingMessageHeaders.GetHeader<string>("User_id", "XML.User.org");

            ClientLst[userID] = cb;
            OperationContext.Current.Channel.Closing += new EventHandler((m, n) =>
              {
                  ClientLst.Remove(userID);
              });
            OperationContext.Current.Channel.Faulted += new EventHandler((m, n) =>
            {
                ClientLst.Remove(userID);
            });
            return userID;

        }
    }
}
