using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockCommon;
using StockDal;
using StockModelData;
using System.Data.SqlClient;
using System.Data;

namespace StockBll
{
     public class StocktakingManageBLL
    {
        private const string STATUS_ERROR_NOT_NO_STOCKED = "非未盘点的单据状态无法审核!!!";
        StocktakingManageDAL MySMDAL = new StocktakingManageDAL();
        public FeedbackInfomation AddStocktakingBill(StockModel sb)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                using (SqlConnection conn = SqlDataHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction st = conn.BeginTransaction();
                    sb.Status = BaseInfo.FindBillStatusIDByName("未盘点");
                    long id = MySMDAL.InsertStocktakingBill(sb, st);
                    sb.StocktakingID = id;
                    bool ret = MySMDAL.GenerateStocktakingDetailInfo(sb, BaseInfo.FindBillStatusIDByName("未盘点"), st);
                    sb = MySMDAL.SelectStocktakingBill(sb.CmstID, sb.StocktakingID, st);
                    st.Commit();
                }
                fi.FeedbackMessage = Tips.SAVE_SUCCESS;
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.Result = sb;
                return fi;
            }
             catch (Exception ex)
            {
                fi.FeedbackMessage = ex.Message.ToString();
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.Result = null;
                return fi;
            }
        }
        public FeedbackInfomation QueryStocktakingBillInfos(StocktakingQuery sq)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                DataSet ds = MySMDAL.SelectStocktakingBillsInfo(sq);
                if (DataValidate.CheckDataSetNotEmpty(ds))
                {
                    fi.Result = ds;
                    fi.FeedbackMessage = "";
                    fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                }
                else
                {
                    fi.Result = null;
                    fi.FeedbackMessage = Tips.QERUY_RESULT_EMPTY;
                    fi.ErrorStatus = STATUS_ADAPTER.QUERY_NODATA;
                }
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = null;
                fi.FeedbackMessage = Tips.QUERY_FAILED + ":" + ex.Message.ToString();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                return fi;
            }
        }

        public FeedbackInfomation QueryStocktakingBillDetailsInfo(long stocktakingId)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                DataSet ds = MySMDAL.SelectStocktakingDetails(stocktakingId);
                if (DataValidate.CheckDataSetNotEmpty(ds))
                {
                    fi.Result = ds;
                    fi.FeedbackMessage = "";
                    fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                }
                else
                {
                    fi.Result = null;
                    fi.FeedbackMessage = Tips.QERUY_RESULT_EMPTY;
                    fi.ErrorStatus = STATUS_ADAPTER.QUERY_NODATA;
                }
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = null;
                fi.FeedbackMessage = Tips.QUERY_FAILED + ":" + ex.Message.ToString();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                return fi;
            }
        }

        public FeedbackInfomation QueryStocktakingBillDetial(long stocktakingDetailId)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                StocktakingBillDetail sbd = MySMDAL.SelectStocktakingBillDetail(stocktakingDetailId);
                if (sbd != null)
                {
                    fi.Result = sbd;
                    fi.FeedbackMessage = "";
                    fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                }
                else
                {
                    fi.Result = null;
                    fi.FeedbackMessage = Tips.QERUY_RESULT_EMPTY;
                    fi.ErrorStatus = STATUS_ADAPTER.QUERY_NODATA;
                }
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = null;
                fi.FeedbackMessage = Tips.QUERY_FAILED + ":" + ex.Message.ToString();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                return fi;
            }
        }
        public FeedbackInfomation OperatorAuth()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
               // StocktakingBillDetail sbd = MySMDAL.SelectStocktakingBillDetail(stocktakingDetailId);
               
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = null;
                fi.FeedbackMessage = Tips.QUERY_FAILED + ":" + ex.Message.ToString();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                return fi;
            }
        }
        private void JudgeStocktakingDetailStatus(long isbId, string status, string message, SqlTransaction st)
        {
            if (MySMDAL.SelectStocktakingDetailStatus(isbId, BaseInfo.FindBillStatusIDByName(status), st) < 0)
            {
                throw new Exception(message);
            }
        }

        private void CheckDetail(long stocktakingId, long stocktakingDetailId, int result, int checker, string remark, SqlTransaction st)
        {
            JudgeStocktakingDetailStatus(stocktakingDetailId, BaseInfo.BillStatuses.STATUS_NO_STOCKTAKED, STATUS_ERROR_NOT_NO_STOCKED, st);
            int ret = MySMDAL.CheckStocktakingBillDetail(stocktakingDetailId, BaseInfo.FindBillStatusIDByName("已盘点"), result, checker, remark, st);
            if (ret > 0)
            {
                int stockedcount = MySMDAL.SelectStocktakingBillDetaisCount(stocktakingId, BaseInfo.FindBillStatusIDByName("已盘点"), st);
                int totalcount = MySMDAL.SelectStocktakingBillDetaisCount(stocktakingId, -1, st);
                if (stockedcount == totalcount)
                {
                    MySMDAL.CheckStocktakingBill(stocktakingId, BaseInfo.FindBillStatusIDByName("盘点完毕"), st);
                }
                else if (stockedcount == 1)
                {
                    MySMDAL.CheckStocktakingBill(stocktakingId, BaseInfo.FindBillStatusIDByName("部分盘点"), st);
                }
            }
        }

     

        public FeedbackInfomation CheckStocktakingDetail(long stocktakingId, long stocktakingDetailId, int result, int checker, string remark)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                using (SqlConnection conn = SqlDataHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction st = conn.BeginTransaction();
                    CheckDetail(stocktakingId, stocktakingDetailId, result, checker, remark, st);
                    StocktakingBillDetail sbd = MySMDAL.SelectStocktakingBillDetail(stocktakingDetailId, st);
                    st.Commit();
                    fi.Result = sbd;
                    fi.FeedbackMessage = Tips.CHECK_SUCCESS;
                    fi.ErrorStatus = STATUS_ADAPTER.CHECK_SUCCESS;
                    return fi;
                }
            }
            catch (Exception ex)
            {
                fi.Result = null;
                fi.ErrorStatus = STATUS_ADAPTER.CHECK_FAILED;
                fi.FeedbackMessage = Tips.CHECK_SUCCESS + ":" + ex.Message.ToString();
                return fi;
            }
        }

      
    }
}
