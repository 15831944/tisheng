using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.DAL;
using CMST.Storage.BackgroundManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.BLL
{
    public class BaseMessageBLL
    {
        BaseMessageDAL MyBaseMessageDAL = new BaseMessageDAL();

        #region 货场属性
        public FeedbackInfomation GetAllDepotsProperty()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectAllDepotsPropertyEntity();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation AddDepotsProperty(DepotsPropertyEntity de)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.InsertDepotsProperty(de);
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_NORMAL;
                fi.FeedbackMessage = "新增成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation EditDepotsProperty(DepotsPropertyEntity de)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.UpdateDepotsProperty(de);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "修改成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation GetDepotsPropertyByName(string name)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectDepotsPropertyByName(name);
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
        #endregion

        #region 入库方式
        public FeedbackInfomation GetAllStorageWay()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectAllStorageWayEntity();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation AddStorageWay(StorageWayEntity se)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.InsertStorageWay(se);
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_NORMAL;
                fi.FeedbackMessage = "新增成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation EditStorageWay(StorageWayEntity se)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.UpdateStorageWay(se);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "修改成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation GetStorageWayByName(string name)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectStorageWayByName(name);
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
        #endregion

        #region 出库方式
        public FeedbackInfomation GetAllOutboundWay()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectAllOutboundWayEntity();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation AddOutboundWay(OutboundWayEntity oe)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.InsertOutboundWay(oe);
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_NORMAL;
                fi.FeedbackMessage = "新增成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation EditOutboundWay(OutboundWayEntity oe)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.UpdateOutboundWay(oe);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "修改成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation GetOutboundWayByName(string name)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectOutboundWayByName(name);
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
        #endregion

        #region 计量方式
        public FeedbackInfomation GetAllMeasureWay()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectAllMeasureWayEntity();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation AddMeasureWay(MeasureWayEntity me)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.InsertMeasureWay(me);
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_NORMAL;
                fi.FeedbackMessage = "新增成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation EditMeasureWay(MeasureWayEntity me)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.UpdateMeasureWay(me);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "修改成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation GetMeasureWayByName(string name)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectMeasureWayByName(name);
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
        #endregion

        #region 费率类型
        public FeedbackInfomation GetAllRateType()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectAllRateTypeEntity();
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation AddRateType(RateTypeEntity rte)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.InsertRateType(rte);
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_NORMAL;
                fi.FeedbackMessage = "新增成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.INSERT_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation EditRateType(RateTypeEntity rte)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.UpdateRateType(rte);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "修改成功";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation GetRateTypeByName(string name)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyBaseMessageDAL.SelectRateTypeByName(name);
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_NORMAL;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.QUERY_ERROR;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
        #endregion
    }
}
