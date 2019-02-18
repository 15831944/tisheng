using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using StockModelData;

namespace StockInterface
{
    [ServiceContract]
    public interface IStocktakingManage
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string AddStocktakingBill(StockModel sm);
        [OperationContract]
        [WebInvoke(Method ="POST",RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.WrappedRequest)]
        string QueryStocktakingBillInfos(StocktakingQuery sq);
        [OperationContract]
        [WebInvoke(Method ="POST",RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.WrappedRequest)]
        string QueryStocktakingBillDetailsInfo(long stocktakingId);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string QueryStocktakingBillDetial(long stocktakingDetailId);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string CheckStocktakingDetail(long stocktakingId, long stocktakingDetailId, int result, int checker, string remark);



    }
}
