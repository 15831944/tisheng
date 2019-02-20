using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.DAL;
using CMST.Storage.BackgroundManage.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.DAL
{
    public class OperationManageDAL
    {
        public int InsertOperation(OperationEntity oe)
        {
            string sqlstr = "insert into dbo.Operation(Ope_Meu_ID,Csy_ID,Ope_Name,Ope_Url)values({0},{1},'{2}','{3}')";
            sqlstr = string.Format(sqlstr, oe.MenuID, oe.CsyID, oe.OperateName, oe.OperateUrl);
            int ret = SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ret > 0)
            {
                return 1;
            }
            return -1;
        }
        public DataSet SelectAllOperation()
        {
            string sqlstr = "select * from dbo.Operation";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                return ds;
            }
            return null;
        }
        public OperationEntity SelectOperationEntity(int operationID)
        {
            string sqlstr = "select * from dbo.Operation where Ope_ID={0}";
            sqlstr = string.Format(sqlstr, operationID);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToOperationEntity(ds);
        }
        public OperationEntity DsToOperationEntity(DataSet ds)
        {
            OperationEntity oe = new OperationEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    oe.OperationID = Convert.ToInt32(dr["Ope_ID"]);
                    oe.OperateName = dr["Ope_Name"].ToString();
                    oe.CsyID = Convert.ToInt32(dr["Csy_ID"]);
                    oe.MenuID = Convert.ToInt32(dr["Ope_Meu_ID"]);
                    oe.OperateUrl = dr["Ope_Url"].ToString();
                }
            }
            return oe;
        }
        public List<OperationEntity> SelectOperationEntity()
        {
            string sqlstr = "select * from dbo.Operation";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToOperationList(ds);
        }
        public List<OperationEntity> DsToOperationList(DataSet ds)
        {
            List<OperationEntity> oes = new List<OperationEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                DataRow dr = ds.Tables[0].Rows[0];
                OperationEntity oe = new OperationEntity();
                oe.OperationID = Convert.ToInt32(dr["Ope_ID"]);
                oe.OperateName = dr["Ope_Name"].ToString();
                oe.CsyID = Convert.ToInt32(dr["Csy_ID"]);
                oe.MenuID = Convert.ToInt32(dr["Ope_Meu_ID"]);
                oe.OperateUrl = dr["Ope_Url"].ToString();
                oes.Add(oe);
            }
            return oes;

        }
    }
}
