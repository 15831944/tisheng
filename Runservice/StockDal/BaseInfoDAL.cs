using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockModelData;
using StockCommon;
using System.Data;
namespace StockDal
{
     public class BaseInfoDAL
    {
        public List<BillStatus> SelectAllBillStatusList()
        {
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), "BillStatus_Select");
            return DsToBillStatusList(ds);
        }
        public List<BillStatus> DsToBillStatusList(DataSet ds)
        {
            List<BillStatus> bses = new List<BillStatus>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    BillStatus bs = new BillStatus();
                    bs.BillStatusId = Convert.ToInt32(dr["BillStatus_Id"]);
                    bs.BillStatusName = dr["BillStatus_Name"].ToString();
                    bses.Add(bs);
                }
            }
            return bses;
        }
    }
}
