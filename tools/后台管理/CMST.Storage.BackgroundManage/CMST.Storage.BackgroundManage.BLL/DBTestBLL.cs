using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.BLL
{
    public class DBTestBLL
    {
        public FeedbackInfomation TestDBConnect(string dbip, string dbport, string dbname, string uid, string pwd)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            SqlDataHelper.SetConnStr(dbip, dbport, dbname, uid, pwd);
            try
            {
                if (SqlDataHelper.ConnectionTest())
                {
                    fi.ErrorStatus = STATUS_ADAPTER.DB_CONNECT_NORMAL;
                    fi.FeedbackMessage = "";
                    fi.Result = Tips.DB_CONNECTTEST_SUCCESS;
                    return fi;
                }
                else
                {
                    fi.ErrorStatus = STATUS_ADAPTER.DB_CONNECT_FAILD;
                    fi.FeedbackMessage = "";
                    fi.Result = Tips.DB_CONNECTTEST_FAILED;
                    return fi;
                }

            }
            catch (Exception ex)
            {
                fi.ErrorStatus = STATUS_ADAPTER.DB_CONNECT_FAILD;
                fi.FeedbackMessage = ex.Message.ToString();
                fi.Result = Tips.DB_CONNECTTEST_FAILED;
                return fi;
            }

        }

        public FeedbackInfomation TestMGDBConnect(string dbip, string dbport, string dbname, string uid, string pwd)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            SqlDataHelper.SetConnMgStr(dbip, dbport, dbname, uid, pwd);
            try
            {
                if (SqlDataHelper.ConnectionMgTest())
                {
                    fi.ErrorStatus = STATUS_ADAPTER.DB_CONNECT_NORMAL;
                    fi.FeedbackMessage = "";
                    fi.Result = Tips.DB_CONNECTTEST_SUCCESS;
                    return fi;
                }
                else
                {
                    fi.ErrorStatus = STATUS_ADAPTER.DB_CONNECT_FAILD;
                    fi.FeedbackMessage = "";
                    fi.Result = Tips.DB_CONNECTTEST_FAILED;
                    return fi;
                }

            }
            catch (Exception ex)
            {
                fi.ErrorStatus = STATUS_ADAPTER.DB_CONNECT_FAILD;
                fi.FeedbackMessage = ex.Message.ToString();
                fi.Result = Tips.DB_CONNECTTEST_FAILED;
                return fi;
            }

        }
    }
}
