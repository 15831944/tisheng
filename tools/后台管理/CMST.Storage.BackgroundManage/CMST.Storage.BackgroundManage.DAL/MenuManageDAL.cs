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
    public class MenuManageDAL
    {
        public int InsertMenu(MenuEntity me)
        {
            string sqlstr = "insert into dbo.Menu (Csy_ID,Meu_Menu,Meu_FatherMenuID,Meu_Rank,Meu_Url)values({0},'{1}',{2},{3},'{4}')";
            sqlstr = string.Format(sqlstr, me.CsyID, me.MenuName, me.FatherID, me.Rank, me.Url );
            int ret = SqlDataHelper.ExecuteNonQuery(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (ret > 0)
            {
                return 1;
            }
            return -1;
        }
        public DataSet SelectAllMenu()
        {
            string sqlstr = "select * from dbo.Menu";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                return ds;
            }
            return null;
        }
        public MenuEntity SelectMenuEntity(int menuID)
        {
            string sqlstr = "select * from dbo.Menu where Meu_ID={0}";
            sqlstr = string.Format(sqlstr, menuID);
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToMenuEntity(ds);
        }
        public MenuEntity DsToMenuEntity(DataSet ds)
        {
            MenuEntity me = new MenuEntity();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    me.MenuID = Convert.ToInt32(dr["Meu_ID"]);
                    me.MenuName = dr["Meu_Menu"].ToString();
                    me.CsyID = Convert.ToInt32(dr["Csy_ID"]);
                    me.FatherID = Convert.ToInt32(dr["Meu_FatherMenuID"]);
                    me.Rank = Convert.ToInt32(dr["Meu_Rank"]);
                    me.Url = dr["Meu_Url"].ToString();
                }
            }
            return me;
        }
        public List<MenuEntity> SelectMenuEntity()
        {
            string sqlstr = "select * from dbo.Menu";
            DataSet ds = SqlDataHelper.ExecuteDataSet(SqlDataHelper.GetConnection(), CommandType.Text, sqlstr);
            return DsToMenuList(ds);
        }
        public List<MenuEntity> DsToMenuList(DataSet ds)
        {
            List<MenuEntity> mes = new List<MenuEntity>();
            if (DataValidate.CheckDataSetNotEmpty(ds))
            {
                DataRow dr = ds.Tables[0].Rows[0];
                MenuEntity me = new MenuEntity();
                me.MenuID = Convert.ToInt32(dr["Meu_ID"]);
                me.MenuName = dr["Meu_Menu"].ToString();
                me.CsyID = Convert.ToInt32(dr["Csy_ID"]);
                me.FatherID = Convert.ToInt32(dr["Meu_FatherMenuID"]);
                me.Rank = Convert.ToInt32(dr["Meu_Rank"]);
                me.Url = dr["Meu_Url"].ToString();
                mes.Add(me);
            }
            return mes;
        }

    }
}
