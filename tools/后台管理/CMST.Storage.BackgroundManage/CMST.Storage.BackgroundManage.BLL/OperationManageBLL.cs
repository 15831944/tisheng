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
    public class OperationManageBLL
    {
        OperationManageDAL MyOperationManageDAL = new OperationManageDAL();
        public FeedbackInfomation SaveOperation(OperationEntity oe)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyOperationManageDAL.InsertOperation(oe);
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
        public FeedbackInfomation GetOperationByID(int OperationID)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyOperationManageDAL.SelectOperationEntity(OperationID);
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

        public FeedbackInfomation GetAllOperation()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyOperationManageDAL.SelectAllOperation();
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
