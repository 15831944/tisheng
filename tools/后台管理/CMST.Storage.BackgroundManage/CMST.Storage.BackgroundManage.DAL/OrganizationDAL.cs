using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.DAL
{
    public class OrganizationDAL
    {
        public int InsertOrganization(OrganizationEntity oe)
        {
            StringBuilder sb = new StringBuilder("insert into dbo.CmstOrganization(Cmst_ID,Cmst_Name,Cmst_IfUse)values(");
            sb.AppendFormat(" {0},", Convert.ToInt32(oe.CmstID));
            sb.AppendFormat(" '{0}',", oe.CmstName);
            sb.AppendFormat(" {0})", oe.CmstIfUse== true ? 1 : 0);
            //DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
            int ret = SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
            if (ret > 0)
            {
                return 1;
            }
            return -1;
        }
        public DataSet SelectOrganizationByCmstId(int cmstId)
        {
            string sqlstr = "select * from dbo.CmstOrganization where Cmst_ID={0}";
            sqlstr = string.Format(sqlstr, cmstId);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return ds;
        }
        public DataSet SelectOrganizationByCmstName(string cmstName)
        {
            string sqlstr = "select * from dbo.CmstOrganization where Cmst_Name='{0}'";
            sqlstr = string.Format(sqlstr, cmstName);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return ds;
        }
        public OrganizationEntity SelectOrganizationByID(int cmstID)
        {
            string sqlstr = "select * from dbo.CmstOrganization where Cmst_ID={0}";
            sqlstr = string.Format(sqlstr, cmstID);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToOrganizationEntity(ds);
        }
        public List<OrganizationEntity> SelectAllOrganizationEntity()
        {
            string sqlstr = "SELECT con.Cmst_ID,con.Cmst_Name,con.Cmst_IfUse,op.Ope_Account from dbo.CmstOrganization AS con LEFT JOIN Operator AS op ON con.Cmst_ID = op.Ope_Cmst_ID WHERE op.Ope_IfSysAccount = 1";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToOrganizationEntityList(ds);
        }
        public List<OrganizationEntity> DsToOrganizationEntityList(DataSet ds)
        {
            List<OrganizationEntity> Oes = new List<OrganizationEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    OrganizationEntity oe = new OrganizationEntity();
                    oe.CmstID = Convert.ToInt32(dr["Cmst_ID"]);
                    oe.CmstName = dr["Cmst_Name"].ToString();
                    oe.CmstSysAccount= dr["Ope_Account"].ToString();
                    oe.CmstIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Cmst_IfUse"]) == true ? false : dr["Cmst_IfUse"]);
                    oe.CmstState = Convert.ToBoolean(dr["Cmst_IfUse"]) == true ? "是" : "否";
                    Oes.Add(oe);
                }
            }
            return Oes;
        }
        public OrganizationEntity DsToOrganizationEntity(DataSet ds)
        {
            OrganizationEntity oe = new OrganizationEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    oe.CmstID = Convert.ToInt32(dr["Cmst_ID"]);
                    oe.CmstName = dr["Cmst_Name"].ToString();
                    oe.CmstIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Cmst_IfUse"]) == true ? false : dr["Cmst_IfUse"]);
                    oe.CmstState = Convert.IsDBNull(dr["Cmst_IfUse"]) == true ? "是" : "否";
                }
            }
            return oe;
        }

        public RoleEntity InsertRoleEtity(RoleEntity re)
        {
            try
            {           
                DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), "Role_Insert", re.CmstID, re.CsyID, re.RoleName, re.Remark, re.IfUse == true ? 1 : 0);
                if (DataValidate.CheckDataSetNotEmpty(ds))
                {
                    re.RoleID = Convert.ToInt32(ds.Tables[0].Rows[0]["Rol_ID"]);
                    return re;
                }
                else
                {
                    throw new Exception("插入角色失败");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<RoleOperations> SelectAllOperationList()
        {
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), "Operation_select");
            return DsToOperationList(ds);
        }
        public List<RoleOperations> DsToOperationList(DataSet ds)
        {
            List<RoleOperations> rops = new List<RoleOperations>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RoleOperations rop = new RoleOperations();
                    rop.OperationID = Convert.ToInt32(dr["Ope_ID"]);
                    rop.OperationName= dr["Ope_Name"].ToString();
                    rops.Add(rop);
                }
            }
            return rops;
        }
        public bool InsertRoleOperate(int roleId, int operationId, int cmstid)
        {
            int ret = SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), "RoleOperate_Insert", roleId, operationId, cmstid);
            if (ret > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckedOperatorAccountRepeate(string account, int operatorId)
        {
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), "Operator_View_Check", account, operatorId);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                return true;
            }
            return false;
        }

        public int InsertOperatorEntity(OperatorEntity oe)
        {
            try
            {
              string sqlstr=$"insert into dbo.Operator(Ope_Account,Ope_Name,Ope_Password,Ope_IfUse,Ope_RevisionTime,Ope_Cmst_ID,Ope_Rol_ID,Ope_IfSysAccount)values('{oe.Account}','{oe.OperatorName}','{oe.Password}','{oe.IfUse}','{oe.UpdateTime}',{oe.CmstID},{oe.RoleID},'{oe.IfSysAccount}')";
                int ret = SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
                if (ret > 0)
                {
                    return 1;
                }
                return -1;            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
