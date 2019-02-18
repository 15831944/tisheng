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
    public class SubjectDAL
    {
        public List<Subject> SelectAllSubjectEntityList()
        {
            string sqlstr = "select * from Subject ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToSubjectEntityList(ds);

        }

        private List<Subject> DsToSubjectEntityList(DataSet ds)
        {
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                List<Subject> Ses = new List<Subject>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Subject se = new Subject
                    {
                        SubjectID = Convert.ToInt32(dr["Sub_Id"]),
                        SubjectName = dr["Sub_Name"].ToString(),
                        SubjectType = Convert.ToBoolean(dr["Sub_Type"])
                    };
                    Ses.Add(se);
                }
                return Ses;
            }
            return null;
        }
    }
}
