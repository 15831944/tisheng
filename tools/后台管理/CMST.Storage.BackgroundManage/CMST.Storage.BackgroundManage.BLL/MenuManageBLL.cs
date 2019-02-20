using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.DAL;
using CMST.Storage.BackgroundManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.BLL
{
    public class MenuManageBLL
    {
        MenuManageDAL MyMenuManageDAL = new MenuManageDAL();
        public FeedbackInfomation SaveMenu(MenuEntity me)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyMenuManageDAL.InsertMenu(me);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
        public FeedbackInfomation GetMenuByID(int menuID)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyMenuManageDAL.SelectMenuEntity(menuID);
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }

        public FeedbackInfomation GetAllMenu()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyMenuManageDAL.SelectAllMenu();
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_SUCCESS;
                fi.FeedbackMessage = "";
                return fi;
            }
            catch (Exception ex)
            {
                fi.Result = "";
                fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                fi.FeedbackMessage = ex.Message.ToString();
                return fi;
            }
        }
    }
}
