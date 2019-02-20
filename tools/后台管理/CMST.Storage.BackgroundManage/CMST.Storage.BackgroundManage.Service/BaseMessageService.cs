using CMST.Storage.BackgroundManage.BLL;
using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Service
{
    public class BaseMessageService
    {
        BaseMessageBLL MyBaseMessageBll = new BaseMessageBLL();
        #region 货场属性
        public string GetAllDepotsProperty()
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetAllDepotsProperty());
        }

        public string AddDepotsProperty(DepotsPropertyEntity de)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.AddDepotsProperty(de));
        }

        public string EditDepotsProperty(DepotsPropertyEntity de)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.EditDepotsProperty(de));
        }

        public string GetDepotsPropertyByName(string name)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetDepotsPropertyByName(name));
        }
        #endregion

        #region 入库方式
        public string GetAllStorageWay()
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetAllStorageWay());
        }

        public string AddStorageWay(StorageWayEntity se)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.AddStorageWay(se));
        }

        public string EditStorageWay(StorageWayEntity se)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.EditStorageWay(se));
        }

        public string GetStorageWayByName(string name)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetStorageWayByName(name));
        }
        #endregion

        #region 出库方式
        public string GetAllOutboundWay()
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetAllOutboundWay());
        }

        public string AddOutboundWay(OutboundWayEntity oe)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.AddOutboundWay(oe));
        }

        public string EditOutboundWay(OutboundWayEntity oe)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.EditOutboundWay(oe));
        }

        public string GetOutboundWayByName(string name)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetOutboundWayByName(name));
        }
        #endregion

        #region 计量方式
        public string GetAllMeasureWay()
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetAllMeasureWay());
        }

        public string AddMeasureWay(MeasureWayEntity me)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.AddMeasureWay(me));
        }

        public string EditMeasureWay(MeasureWayEntity me)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.EditMeasureWay(me));
        }

        public string GetMeasureWayByName(string name)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetMeasureWayByName(name));
        }
        #endregion

        #region 费率类型
        public string GetAllRateType()
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetAllRateType());
        }

        public string AddRateType(RateTypeEntity rte)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.AddRateType(rte));
        }

        public string EditRateType(RateTypeEntity rte)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.EditRateType(rte));
        }

        public string GetRateTypeByName(string name)
        {
            return JsonConvert.SerializeObject(MyBaseMessageBll.GetRateTypeByName(name));
        }
        #endregion
    }
}
