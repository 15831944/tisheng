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
    public class SignTypeDAL
    {

            public List<SignType> SelectSignTypeEntityList()
            {
                string sqlstr = "select * from SignType";
                DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
                return DsToSignTypeEntityList(ds);
            }

            private List<SignType> DsToSignTypeEntityList(DataSet ds)
            {
                if (DataValidate.CheckDataSetNotEmpty(ds))
                {
                    List<SignType> sts = new List<SignType>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        sts.Add(new SignType
                        {
                            SignTypeID = Convert.ToInt32(dr[SignTypeTab.STY_ID]),
                            SignTypeName = dr[SignTypeTab.STY_NAME].ToString()
                        });
                    }
                    return sts;
                }
                return null;
            }

            #region
            public DataSet SelectSignType()
            {
                string sqlstr = "select * from SignType";
                return SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            }
            #endregion
        }
    }
