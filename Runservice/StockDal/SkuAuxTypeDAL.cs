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
    public class SkuAuxTypeDAL
    {
        public List<SkuAuxType> SelectSkuAuxTypeEntityList()
        {
            string sqlstr = "select * from SkuAuxType ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToSignTypeEntityList(ds);
        }

        private List<SkuAuxType> DsToSignTypeEntityList(DataSet ds)
        {
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                List<SkuAuxType> sats = new List<SkuAuxType>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sats.Add(new SkuAuxType
                    {
                        AuxTypeID = Convert.ToInt32(dr[SkuAuxTypeTab.SAT_ID]),
                        AuxTypeName = dr[SkuAuxTypeTab.SAT_NAME].ToString()
                    });
                }
                return sats;
            }
            return null;
        }
    }
}
