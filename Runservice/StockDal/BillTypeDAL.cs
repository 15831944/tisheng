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
    public class BillTypeDAL
    {
        public List<BillType> SelectAllBillTypeEntity()
        {
            string sqlstr = "select * from BillType ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToBillTypeEntity(ds);

        }

        private List<BillType> DsToBillTypeEntity(DataSet ds)
        {
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                List<BillType> Bes = new List<BillType>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    BillType Bte = new BillType
                    {
                        BillTypeID = Convert.ToInt32(dr[BillTypeTab.BTY_ID]),
                        BillTypeName = dr[BillTypeTab.BTY_NAME].ToString(),
                    };
                    Bes.Add(Bte);
                }
                return Bes;
            }
            return null;
        }
    }
}
