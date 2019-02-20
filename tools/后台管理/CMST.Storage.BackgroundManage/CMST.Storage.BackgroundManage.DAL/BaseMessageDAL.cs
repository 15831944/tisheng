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
    public class BaseMessageDAL
    {

        #region 货场属性
        public List<DepotsPropertyEntity> SelectAllDepotsPropertyEntity()
        {
            string sqlstr = "select * from dbo.DepotsProperty";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToDepotsPropertyEntityList(ds);
        }
        public List<DepotsPropertyEntity> DsToDepotsPropertyEntityList(DataSet ds)
        {
            List<DepotsPropertyEntity> des = new List<DepotsPropertyEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DepotsPropertyEntity de = new DepotsPropertyEntity();
                    de.DprId = Convert.ToInt32(dr["Dpr_Id"]);
                    de.DprName = dr["Dpr_Name"].ToString();
                    de.DprRemark = dr["Dpr_Remark"].ToString();
                    de.DprIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Dpr_IfUse"]) == true ? false : dr["Dpr_IfUse"]);
                    de.DprIfUse2 = Convert.ToBoolean(dr["Dpr_IfUse"]) == true ? "是" : "否";
                    des.Add(de);
                }
            }
            return des;
        }
        public int InsertDepotsProperty(DepotsPropertyEntity de)
        {
            StringBuilder sb = new StringBuilder("insert into DepotsProperty(Dpr_Name,Dpr_Remark,Dpr_IfUse) values(");
            sb.AppendFormat(" '{0}',", de.DprName);
            sb.AppendFormat(" '{0}',", de.DprRemark);
            sb.AppendFormat(" '{0}')", de.DprIfUse == true ? 1 : 0);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public int UpdateDepotsProperty(DepotsPropertyEntity de)
        {
            StringBuilder sb = new StringBuilder("update dbo.DepotsProperty set");
            sb.AppendFormat(" Dpr_Remark='{0}', ", de.DprRemark);
            sb.AppendFormat(" Dpr_IfUse={0} ", de.DprIfUse == true ? 1 : 0); 
            sb.AppendFormat(" where Dpr_Id={0}", de.DprId);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public DepotsPropertyEntity SelectDepotsPropertyByName(string name)
        {
            string sqlstr = "select * from dbo.DepotsProperty where Dpr_name='{0}'";
            sqlstr = String.Format(sqlstr,name);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DsToDepotsPropertyEntity(ds);
            }
            else
            {
                return null;
            }
        }
        public DepotsPropertyEntity DsToDepotsPropertyEntity(DataSet ds)
        {
            DepotsPropertyEntity de = new DepotsPropertyEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                var dr = ds.Tables[0].Rows[0];
                de.DprId = Convert.ToInt32(dr["Dpr_Id"]);
                de.DprName = dr["Dpr_Name"].ToString();
                de.DprRemark = dr["Dpr_Remark"].ToString();
                de.DprIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Dpr_IfUse"]) == true ? false : dr["Dpr_IfUse"]);
                de.DprIfUse2 = Convert.ToBoolean(dr["Dpr_IfUse"]) == true ? "是" : "否";
            }
            return de;
        }
        #endregion

        #region 入库方式
        public List<StorageWayEntity> SelectAllStorageWayEntity()
        {
            string sqlstr = "select * from dbo.StorageWay";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToStorageWayEntityList(ds);
        }
        public List<StorageWayEntity> DsToStorageWayEntityList(DataSet ds)
        {
            List<StorageWayEntity> ses = new List<StorageWayEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    StorageWayEntity se = new StorageWayEntity();
                    se.SwaId = Convert.ToInt32(dr["Swa_Id"]);
                    se.SwaName = dr["Swa_Name"].ToString();
                    se.SwaRemark = dr["Swa_Remark"].ToString();
                    se.SwaIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Swa_IfUse"]) == true ? false : dr["Swa_IfUse"]);
                    se.SwaIfUse2 = Convert.ToBoolean(dr["Swa_IfUse"]) == true ? "是" : "否";
                    ses.Add(se);
                }
            }
            return ses;
        }
        public int InsertStorageWay(StorageWayEntity se)
        {
            StringBuilder sb = new StringBuilder("insert into StorageWay(Swa_Name,Swa_Remark,Swa_IfUse) values(");
            sb.AppendFormat(" '{0}',", se.SwaName);
            sb.AppendFormat(" '{0}',", se.SwaRemark);
            sb.AppendFormat(" '{0}')", se.SwaIfUse == true ? 1 : 0);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public int UpdateStorageWay(StorageWayEntity se)
        {
            StringBuilder sb = new StringBuilder("update dbo.StorageWay set");
            sb.AppendFormat(" Swa_Remark='{0}', ", se.SwaRemark);
            sb.AppendFormat(" Swa_IfUse={0} ", se.SwaIfUse == true ? 1 : 0);
            sb.AppendFormat(" where Swa_Id={0}", se.SwaId);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public StorageWayEntity SelectStorageWayByName(string name)
        {
            string sqlstr = "select * from dbo.StorageWay where Swa_Name='{0}'";
            sqlstr = String.Format(sqlstr, name);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DsToStorageWayEntity(ds);
            }
            else
            {
                return null;
            }
        }
        public StorageWayEntity DsToStorageWayEntity(DataSet ds)
        {
            StorageWayEntity se = new StorageWayEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                var dr = ds.Tables[0].Rows[0];
                se.SwaId = Convert.ToInt32(dr["Swa_Id"]);
                se.SwaName = dr["Swa_Name"].ToString();
                se.SwaRemark = dr["Swa_Remark"].ToString();
                se.SwaIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Swa_IfUse"]) == true ? false : dr["Swa_IfUse"]);
                se.SwaIfUse2 = Convert.ToBoolean(dr["Swa_IfUse"]) == true ? "是" : "否";
            }
            return se;
        }
        #endregion

        #region 出库方式
        public List<OutboundWayEntity> SelectAllOutboundWayEntity()
        {
            string sqlstr = "select * from dbo.OutboundWay";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToOutboundWayEntityList(ds);
        }
        public List<OutboundWayEntity> DsToOutboundWayEntityList(DataSet ds)
        {
            List<OutboundWayEntity> oes = new List<OutboundWayEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    OutboundWayEntity oe = new OutboundWayEntity();
                    oe.OwaId = Convert.ToInt32(dr["Owa_Id"]);
                    oe.OwaName = dr["Owa_Name"].ToString();
                    oe.OwaRemark = dr["Owa_Remark"].ToString();
                    oe.OwaIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Owa_IfUse"]) == true ? false : dr["Owa_IfUse"]);
                    oe.OwaIfUse2 = Convert.ToBoolean(dr["Owa_IfUse"]) == true ? "是" : "否";
                    oes.Add(oe);
                }
            }
            return oes;
        }
        public int InsertOutboundWay(OutboundWayEntity oe)
        {
            StringBuilder sb = new StringBuilder("insert into OutboundWay(Owa_Name,Owa_Remark,Owa_IfUse) values(");
            sb.AppendFormat(" '{0}',", oe.OwaName);
            sb.AppendFormat(" '{0}',", oe.OwaRemark);
            sb.AppendFormat(" '{0}')", oe.OwaIfUse == true ? 1 : 0);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public int UpdateOutboundWay(OutboundWayEntity oe)
        {
            StringBuilder sb = new StringBuilder("update dbo.OutboundWay set");
            sb.AppendFormat(" Owa_Remark='{0}', ", oe.OwaRemark);
            sb.AppendFormat(" Owa_IfUse={0} ", oe.OwaIfUse == true ? 1 : 0);
            sb.AppendFormat(" where Owa_Id={0}", oe.OwaId);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public OutboundWayEntity SelectOutboundWayByName(string name)
        {
            string sqlstr = "select * from dbo.OutboundWay where Owa_name='{0}'";
            sqlstr = String.Format(sqlstr, name);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DsToOutboundWayEntity(ds);
            }
            else
            {
                return null;
            }
        }
        public OutboundWayEntity DsToOutboundWayEntity(DataSet ds)
        {
            OutboundWayEntity oe = new OutboundWayEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                var dr = ds.Tables[0].Rows[0];
                oe.OwaId = Convert.ToInt32(dr["Owa_Id"]);
                oe.OwaName = dr["Owa_Name"].ToString();
                oe.OwaRemark = dr["Owa_Remark"].ToString();
                oe.OwaIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Owa_IfUse"]) == true ? false : dr["Owa_IfUse"]);
                oe.OwaIfUse2 = Convert.ToBoolean(dr["Owa_IfUse"]) == true ? "是" : "否";
            }
            return oe;
        }
        #endregion

        #region 计量方式
        public List<MeasureWayEntity> SelectAllMeasureWayEntity()
        {
            string sqlstr = "select * from dbo.MeasureWay";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToMeasureWayEntityList(ds);
        }
        public List<MeasureWayEntity> DsToMeasureWayEntityList(DataSet ds)
        {
            List<MeasureWayEntity> mes = new List<MeasureWayEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    MeasureWayEntity me = new MeasureWayEntity();
                    me.MwaId = Convert.ToInt32(dr["Mwa_Id"]);
                    me.MwaName = dr["Mwa_Name"].ToString();
                    me.MwaRemark = dr["Mwa_Remark"].ToString();
                    me.MwaIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Mwa_IfUse"]) == true ? false : dr["Mwa_IfUse"]);
                    me.MwaIfUse2 = Convert.ToBoolean(dr["Mwa_IfUse"]) == true ? "是" : "否";
                    mes.Add(me);
                }
            }
            return mes;
        }
        public int InsertMeasureWay(MeasureWayEntity me)
        {
            StringBuilder sb = new StringBuilder("insert into MeasureWay(Mwa_Name,Mwa_Remark,Mwa_IfUse) values(");
            sb.AppendFormat(" '{0}',", me.MwaName);
            sb.AppendFormat(" '{0}',", me.MwaRemark);
            sb.AppendFormat(" '{0}')", me.MwaIfUse == true ? 1 : 0);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public int UpdateMeasureWay(MeasureWayEntity me)
        {
            StringBuilder sb = new StringBuilder("update dbo.MeasureWay set");
            sb.AppendFormat(" Mwa_Remark='{0}', ", me.MwaRemark);
            sb.AppendFormat(" Mwa_IfUse={0} ", me.MwaIfUse == true ? 1 : 0);
            sb.AppendFormat(" where Mwa_Id={0}", me.MwaId);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public MeasureWayEntity SelectMeasureWayByName(string name)
        {
            string sqlstr = "select * from dbo.MeasureWay where Mwa_name='{0}'";
            sqlstr = String.Format(sqlstr, name);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DsToMeasureWayEntity(ds);
            }
            else
            {
                return null;
            }
        }
        public MeasureWayEntity DsToMeasureWayEntity(DataSet ds)
        {
            MeasureWayEntity me = new MeasureWayEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                var dr = ds.Tables[0].Rows[0];
                me.MwaId = Convert.ToInt32(dr["Mwa_Id"]);
                me.MwaName = dr["Mwa_Name"].ToString();
                me.MwaRemark = dr["Mwa_Remark"].ToString();
                me.MwaIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Mwa_IfUse"]) == true ? false : dr["Mwa_IfUse"]);
                me.MwaIfUse2 = Convert.ToBoolean(dr["Mwa_IfUse"]) == true ? "是" : "否";
            }
            return me;
        }
        #endregion

        #region 费率类型
        public List<RateTypeEntity> SelectAllRateTypeEntity()
        {
            string sqlstr = "select * from dbo.RateType";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToRateTypeEntityList(ds);
        }
        public List<RateTypeEntity> DsToRateTypeEntityList(DataSet ds)
        {
            List<RateTypeEntity> rtes = new List<RateTypeEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RateTypeEntity rte = new RateTypeEntity();
                    rte.RtyId = Convert.ToInt32(dr["Rty_Id"]);
                    rte.RtyName = dr["Rty_Name"].ToString();
                    rte.RtyRemark = dr["Rty_Remark"].ToString();
                    rte.RtyIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Rty_IfUse"]) == true ? false : dr["Rty_IfUse"]);
                    rte.RtyIfUse2 = Convert.ToBoolean(dr["Rty_IfUse"]) == true ? "是" : "否";
                    rtes.Add(rte);
                }
            }
            return rtes;
        }
        public int InsertRateType(RateTypeEntity rte)
        {
            StringBuilder sb = new StringBuilder("insert into RateType(Rty_Name,Rty_Remark,Rty_IfUse) values(");
            sb.AppendFormat(" '{0}',", rte.RtyName);
            sb.AppendFormat(" '{0}',", rte.RtyRemark);
            sb.AppendFormat(" '{0}')", rte.RtyIfUse == true ? 1 : 0);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public int UpdateRateType(RateTypeEntity rte)
        {
            StringBuilder sb = new StringBuilder("update dbo.RateType set");
            sb.AppendFormat(" Rty_Remark='{0}', ", rte.RtyRemark);
            sb.AppendFormat(" Rty_IfUse={0} ", rte.RtyIfUse == true ? 1 : 0);
            sb.AppendFormat(" where Rty_Id={0}", rte.RtyId);
            return SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sb.ToString());
        }

        public RateTypeEntity SelectRateTypeByName(string name)
        {
            string sqlstr = "select * from dbo.RateType where Rty_Name='{0}'";
            sqlstr = String.Format(sqlstr, name);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DsToRateTypeEntity(ds);
            }
            else
            {
                return null;
            }
        }
        public RateTypeEntity DsToRateTypeEntity(DataSet ds)
        {
            RateTypeEntity rte = new RateTypeEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                var dr = ds.Tables[0].Rows[0];
                rte.RtyId = Convert.ToInt32(dr["Rty_Id"]);
                rte.RtyName = dr["Rty_Name"].ToString();
                rte.RtyRemark = dr["Rty_Remark"].ToString();
                rte.RtyIfUse = Convert.ToBoolean(Convert.IsDBNull(dr["Rty_IfUse"]) == true ? false : dr["Rty_IfUse"]);
                rte.RtyIfUse2 = Convert.ToBoolean(dr["Rty_IfUse"]) == true ? "是" : "否";
            }
            return rte;
        }
        #endregion
    }
}
