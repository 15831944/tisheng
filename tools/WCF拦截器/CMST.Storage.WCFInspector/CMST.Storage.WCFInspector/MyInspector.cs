using RedisUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.WCFInspector
{
    public class MyMessageInspector : IClientMessageInspector, IDispatchMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {

        }
        /// <summary>
        /// 服务端收到请求后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="channel"></param>
        /// <param name="instanceContext"></param>
        /// <returns></returns>
        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            RedisHelper r = RedisHelper.GetRedisHelper();
            string url = channel.LocalAddress.Uri.ToString();
            WebOperationContext woc = WebOperationContext.Current;//http请求方式非WCF代理类调用下的检查方式
            string s = request.ToString();
            //获得当前请求头中的TokenID
            var tokenID = woc.IncomingRequest.Headers["TokenID"];
            var uri = woc.IncomingRequest.UriTemplateMatch;
            if (uri != null)
            {
                var address = woc.IncomingRequest.UriTemplateMatch.RequestUri.ToString();
                //请求为登录的时候不过滤
                if (!address.EndsWith("LoginManage/Login"))
                {
                    //redis判断
                    string user = r.StringGet(tokenID);
                    if (string.IsNullOrEmpty(user))
                    {
                        throw new Exception("tokenId$登录失效，请重新登录%");
                    }
//                     if (tokenID != "admin")//redis判断
//                     {
//                         woc.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.MethodNotAllowed;
//                         // woc.OutgoingResponse.StatusDescription = "222";
//                         throw new Exception("tokenId$登录失效，请重新登录%");
//                     }
                }
            }
            else//WCF代理类调用下的检查方式
            {
                OperationContext oc = OperationContext.Current;
                
                var headers = OperationContext.Current.IncomingMessageHeaders;
                var actionAddress = headers.Action;
                //1.请求为登录的时候不过滤 2.代理类生成时请求不过滤
                if (!string.IsNullOrEmpty(actionAddress) && !actionAddress.EndsWith("ILoginManage/Login"))
                {
                    var token = GetHeaderValue("TokenID");
                    string user = r.StringGet(token);
                    if (string.IsNullOrEmpty(user))
                    {
                        throw new Exception("tokenID失效，请重新登录");
                    }        
//                      if (token != "admin") //redis判断
//                      {
//                          throw new Exception("请求无效!!!");                       
//                      }                
                }

            }
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {

        }
        /// <summary>
        /// 客户端发送请求之前
        /// </summary>
        /// <param name="request"></param>
        /// <param name="channel"></param>
        /// <returns></returns>
        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            string wcfAddress = channel.Via.ToString();
            string token = TokenStatic.GetToken();
            var tokenHeader = MessageHeader.CreateHeader("TokenID", "http://tempuri.org", token, false, "");
            request.Headers.Add(tokenHeader);
          
            return null;
        }
        /// <summary>
        /// 获取请求头中的token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ns"></param>
        /// <returns></returns>
        private string GetHeaderValue(string name, string ns = "http://tempuri.org")
        {
            var headers = OperationContext.Current.IncomingMessageHeaders;
            var index = headers.FindHeader(name, ns);
            if (index > -1)
                return headers.GetHeader<string>(index);
            else
                return null;
        }
    }
    public class MyEndpointBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {

        }
        /// <summary>
        /// 客户端
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="clientRuntime"></param>
        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new MyMessageInspector());
        }
        /// <summary>
        /// 服务端
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="endpointDispatcher"></param>
        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new MyMessageInspector());
        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }
    }
}
