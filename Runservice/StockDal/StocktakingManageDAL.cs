using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockModelData;
using StockCommon;


namespace StockDal
{
    public class StocktakingManageDAL
    {
        private const string INSERT_STOCKTAKINGBILL_ERROR = "新增盘点单失败";
        private const string INSERT_STOCKTACKINGINFO_ERROR = "新增盘点明细信息失败";
        public long InsertStocktakingBill(StockModel sb, SqlTransaction st)
        {
            string sqlstr = $" insert into StocktakingBill ( Sb_Cmst_ID, Sb_Dep_ID, Sb_Rar_Id, Sb_Com_ID, Sb_Ope_Maker, Sb_MakeTime, Sb_Status) values ({sb.CmstID},{(sb.DepotID == null ? "NULL" : sb.DepotID.ToString())},{(sb.ReservoirID == null ? "NULL" : sb.ReservoirID.ToString())},{(sb.CompanyID == null ? "NULL" : sb.CompanyID.ToString())},{sb.Maker},getdate(),{sb.Status});select @@Identity;";
            DataSet ds = SqlDataHelper.ExecuteDataSet(st, CommandType.Text, sqlstr);
            long ret = -1;
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                ret = Convert.ToInt64(ds.Tables[0].Rows[0][0] ?? -1);
                return ret;
            }
            else
            {
                throw new Exception(INSERT_STOCKTAKINGBILL_ERROR);
            }
        }

        public bool GenerateStocktakingDetailInfo(StockModel sb, int Status, SqlTransaction st)
        {
            StringBuilder sqlstrsb = new StringBuilder($" Insert into StocktakingBillDetail SELECT {sb.StocktakingID} AS Sbd_Sb_Id, s.Sto_Com_ID AS Sbd_Com_Id, s.Sto_Sku_Id AS Sbd_Sku_Id, s.Sto_Gal_Id AS Sbd_Gal_Id, SUM(s.Sto_PackingNum) AS Sbd_PN, SUM(s.Sto_AccountingNum)  AS Sbd_AN, {Status} AS Sbd_Status, NULL AS Sbd_Result, NULL AS Sbd_Ope_Checker, NULL AS Sbd_CheckTime, NULL AS Sbd_Remark FROM Stock AS s left JOIN GoodsAllocation AS ga ON ga.Gal_Id = s.Sto_Gal_Id left JOIN ReservoirArea AS ra ON ra.Rar_Id = ga.Gal_Rar_Id left JOIN Depots AS d ON d.Dep_ID = ra.Rar_Dep_ID where (s.Sto_Sub_Id = 5 OR s.Sto_Sub_Id = 13 OR s.Sto_Sub_Id = 24) and s.Sto_Gal_Id IS NOT NULL and (s.Sto_PackingNum>0 or s.Sto_AccountingNum>0) and d.DEP_Cmst_ID = {sb.CmstID} ");
            if (sb.CompanyID != null && sb.CompanyID > 0)
            {
                sqlstrsb.Append($" and s.Sto_Com_ID = {sb.CompanyID} ");
            }
            if (sb.DepotID != null && sb.DepotID > 0)
            {
                sqlstrsb.Append($" and d.Dep_ID = {sb.DepotID} ");
            }
            if (sb.ReservoirID != null && sb.ReservoirID > 0)
            {
                sqlstrsb.Append($" and ra.Rar_Id = {sb.ReservoirID} ");
            }
            sqlstrsb.Append(" GROUP BY s.Sto_Com_ID,s.Sto_Sku_Id,s.Sto_Gal_Id ");
            int ret = SqlDataHelper.ExecuteNonQuery(st, CommandType.Text, sqlstrsb.ToString());
            if (ret > 0)
            {
                return true;
            }
            throw new Exception(INSERT_STOCKTACKINGINFO_ERROR);
        }

        public StockModel SelectStocktakingBill(int cmstId, long Id, SqlTransaction st)
        {
            string sqlstr = $" select * from StocktakingView where StackingBillID = {Id} and CmstID = {cmstId} ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(st, CommandType.Text, sqlstr);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                return DrToStocktakingBill(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        private StockModel DrToStocktakingBill(DataRow dr)
        {
            StockModel sb = new StockModel();
            sb.StocktakingID = Convert.ToInt64(dr["StackingBillID"]);
            sb.CmstID = Convert.ToInt32(dr["CmstID"]);
            sb.DepotID = DataValidate.GetValueOrNullInt(dr["DepotID"]);
            sb.DepotName = dr["DepotName"]?.ToString();
            sb.ReservoirID = DataValidate.GetValueOrNullInt(dr["ReservoirID"]);
            sb.ReservoirName = dr["ReservoirName"]?.ToString();
            sb.CompanyID = DataValidate.GetValueOrNullInt(dr["CompanyID"]);
            sb.CompanyName = dr["CompanyName"]?.ToString();
            sb.Maker = Convert.ToInt32(dr["Maker"]);
            sb.MakerName = dr["MakerName"].ToString();
            sb.MakeTime = Convert.ToDateTime(dr["MakeTime"]);
            sb.Status = Convert.ToInt32(dr["Status"]);
            sb.StatusName = dr["StatusName"].ToString();
            return sb;
        }

        public DataSet SelectStocktakingBillsInfo(StocktakingQuery sq)
        {
            StringBuilder sqlsb = new StringBuilder($" select * from StocktakingView where CmstID = {sq.CmstID} ");
            if (sq.CompanyID > 0)
            {
                sqlsb.Append($" and CompanyID = {sq.CompanyID} ");
            }
            if (sq.DepotID > 0)
            {
                sqlsb.Append($" and DepotID = {sq.DepotID} ");
            }
            if (sq.ReservoirID > 0)
            {
                sqlsb.Append($" and ReservoirID = {sq.ReservoirID} ");
            }
            sqlsb.Append($" and MakeTime >= '{sq.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}' and MakeTime <= '{sq.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}' ");
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlsb.ToString());
            return ds;
        }

        public DataSet SelectStocktakingDetails(long stocktakingId)
        {
            string sqlstr = $" select * from StocktakingDetailInfo where StocktakingID = {stocktakingId} ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return ds;
        }



        public StocktakingBillDetail SelectStocktakingBillDetail(long stocktakingDetailId, SqlTransaction st = null)
        {
            string sqlstr = $" select * from StocktakingDetailInfo where StocktakingDetailID = {stocktakingDetailId} ";
            DataSet ds;
            if (st == null)
                ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            else
                ds = SqlDataHelper.ExecuteDataSet(st, CommandType.Text, sqlstr);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                return DrToStocktakingBillDetail(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public int CheckStocktakingBillDetail(long stocktakingDetailId, int status, int result, int checker, string remark, SqlTransaction st)
        {
            string sqlstr = $" update StocktakingBillDetail set Sbd_Status  = {status}, Sbd_Result = {result}, Sbd_Ope_Checker = {checker}, Sbd_CheckTime = getdate(), Sbd_Remark = @Remark where Sbd_Id = {stocktakingDetailId} ";
            SqlParameter spRemark = new SqlParameter("@Remark", SqlDbType.NVarChar, 255)
            {
                Value = remark
            };
            return SqlDataHelper.ExecuteNonQuery(st, CommandType.Text, sqlstr, spRemark);
        }

        public int CheckStocktakingBill(long stocktakingId, int status, SqlTransaction st)
        {
            string sqlstr = $" update StocktakingBill set Sb_Status = {status} where Sb_Id = {stocktakingId} ";
            return SqlDataHelper.ExecuteNonQuery(st, CommandType.Text, sqlstr);
        }

        public int SelectStocktakingBillDetaisCount(long stocktakingId, int status, SqlTransaction st)
        {
            StringBuilder sqlsb = new StringBuilder($" select count(Sbd_Id) from StocktakingBillDetail where Sbd_sb_id = {stocktakingId} ");
            if (status > 0)
            {
                sqlsb.Append($" and Sbd_Status = {status} ");
            }
            DataSet ds = SqlDataHelper.ExecuteDataSet(st, CommandType.Text, sqlsb.ToString());
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            return -1;
        }



        public int SelectStocktakingDetailStatus(long stocktakingDetailId, int status, SqlTransaction st)
        {
            string sqlstr = $" select Count(Sbd_Id) from StocktakingBillDetail where Sbd_Id = {stocktakingDetailId} and Sbd_Status = {status} ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(st, CommandType.Text, sqlstr);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                int ret = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (ret > 0)
                    return ret;
            }
            return -1;
        }

        public int SelectStocktakingStatus(long stocktakingId, int status, SqlTransaction st)
        {
            string sqlstr = $" select Count(Sb_Id) from StocktakingBill where Sb_Id = {stocktakingId} and Sb_Status = {status} ";
            DataSet ds = SqlDataHelper.ExecuteDataSet(st, CommandType.Text, sqlstr);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                int ret = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (ret > 0)
                    return ret;
            }
            return -1;
        }

        private StocktakingBillDetail DrToStocktakingBillDetail(DataRow dr)
        {
            StocktakingBillDetail sbd = new StocktakingBillDetail();
            sbd.StocktakingDetailID = Convert.ToInt64(dr["StocktakingDetailID"]);
            sbd.StocktakingID = Convert.ToInt64(dr["StocktakingID"]);
            sbd.CompanyID = Convert.ToInt32(dr["CompanyID"]);
            sbd.CompanyName = dr["CompanyName"].ToString();
            sbd.DepotName = dr["DepotName"].ToString();
            sbd.ReservoirName = dr["ReservoirName"].ToString();
            sbd.GalID = Convert.ToInt32(dr["GalID"]);
            sbd.GalName = dr["GalName"]?.ToString();
            sbd.GalDescript = dr["GalDescript"]?.ToString();
            sbd.SkuID = Convert.ToInt32(dr["SkuID"]);
            sbd.ProductName = dr["ProductName"]?.ToString();
            sbd.GoodsName = dr["GoodsName"]?.ToString();
            sbd.Spec = dr["Spec"]?.ToString();
            sbd.Grade = dr["Grade"]?.ToString();
            sbd.Manufacturer = dr["Manufacturer"]?.ToString();
            sbd.Packaging = dr["Packaging"]?.ToString();
            sbd.SignType = dr["SignType"]?.ToString();
            sbd.SignNum = dr["SignNum"]?.ToString();
            sbd.Spare = dr["Spare"]?.ToString();
            sbd.PN = Convert.ToInt32(dr["PN"]);
            sbd.AN = Convert.ToDecimal(dr["AN"]);
            sbd.Status = Convert.ToInt32(dr["Status"]);
            sbd.StatusName = dr["StatusName"].ToString();
            sbd.ResultStatus = DataValidate.GetValueOrNullInt(dr["ResultStatus"]);
            sbd.ResultStatusName = dr["ResultStatusName"]?.ToString();
            sbd.Checker = DataValidate.GetValueOrNullInt(dr["Checker"]);
            sbd.CheckName = dr["CheckName"]?.ToString();
            sbd.CheckTime = DataValidate.GetValueOrNullDateTime(dr["CheckTime"]);
            sbd.Remark = dr["Remark"]?.ToString();
            return sbd;
        }
        
    }
}
