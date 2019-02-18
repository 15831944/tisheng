using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockInterface;
using System.ServiceModel;
using StockModelData;
using StockBll;
using Newtonsoft.Json;

namespace StockService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, AddressFilterMode = AddressFilterMode.Any)]
    public class StockTakingManage : IStocktakingManage
    {
        StocktakingManageBLL MySMBLL = new StocktakingManageBLL();
        public string AddStocktakingBill(StockModel sm)
        {
            return JsonConvert.SerializeObject(MySMBLL.AddStocktakingBill(sm));
        }

        public string CheckStocktakingDetail(long stocktakingId, long stocktakingDetailId, int result, int checker, string remark)
        {
            return JsonConvert.SerializeObject(MySMBLL.CheckStocktakingDetail(stocktakingId, stocktakingDetailId, result, checker, remark));
        }

        public string QueryStocktakingBillDetailsInfo(long stocktakingId)
        {
            return JsonConvert.SerializeObject(MySMBLL.QueryStocktakingBillDetailsInfo(stocktakingId));
        }
    

        public string QueryStocktakingBillDetial(long stocktakingDetailId)
        {
        return JsonConvert.SerializeObject(MySMBLL.QueryStocktakingBillDetial(stocktakingDetailId));
    }

        public string QueryStocktakingBillInfos(StocktakingQuery sq)
        {
            return JsonConvert.SerializeObject(MySMBLL.QueryStocktakingBillInfos(sq));
        }
    }
}
