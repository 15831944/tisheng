using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.DAL;
using CMST.Storage.BackgroundManage.Data;
using MD5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CMST.Storage.BackgroundManage.BLL
{
    public class OrganizationBLL
    {
        OrganizationDAL MyOrganizationDAL = new OrganizationDAL();
        /// <summary>
        /// 创建账套
        /// </summary>
        /// <param name="oe"></param>
        /// <returns></returns>
       public FeedbackInfomation SaveOrganization(OrganizationEntity oe)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    //判断账套编号和名称是否重复
                    if (CheckCmstID(oe.CmstID))
                    {
                        fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                        fi.Result = oe;
                        fi.FeedbackMessage = "账套编号重复";
                        return fi;
                    }
                    if (CheckCmstName(oe.CmstName))
                    {
                        fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                        fi.Result = oe;
                        fi.FeedbackMessage = "账套名称重复";
                        return fi;
                    }
                    //保存账套信息
                    MyOrganizationDAL.InsertOrganization(oe);

                    //保存默认角色信息和角色操作
                    RoleEntity re = new RoleEntity();
                    re.CmstID = oe.CmstID;
                    re.CsyID = 1;
                    re.RoleName = "超级管理员";
                    re.IfUse = true;
                    re = MyOrganizationDAL.InsertRoleEtity(re);
                    re.Ros =MyOrganizationDAL.SelectAllOperationList();
                    foreach (var ro in re.Ros )
                    {
                        MyOrganizationDAL.InsertRoleOperate(re.RoleID,ro.OperationID,re.CmstID);
                    }

                    //保存账套主管信息（系统默认账号）
                    OperatorEntity ope = new OperatorEntity();
                    ope.Account = oe.CmstSysAccount;
                    string str = Encrypt.Encrypt_MD5("000000");
                    ope.Password = str;
                    ope.OperatorName = "系统管理员";
                    ope.IfSysAccount = true;
                    ope.RoleID = re.RoleID;
                    ope.CmstID = oe.CmstID;
                    ope.IfUse = true;
                    ope.UpdateTime = DateTime.Now;
                    if (MyOrganizationDAL.CheckedOperatorAccountRepeate(ope.Account, ope.OperatorID))
                    {
                        fi.ErrorStatus = STATUS_ADAPTER.SAVE_FAILED;
                        fi.Result = oe;
                        fi.FeedbackMessage = "账套主管重复";
                        return fi;
                    }
                    MyOrganizationDAL.InsertOperatorEntity(ope);
                    scope.Complete();
                }
                fi.Result ="";
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
       private bool CheckCmstID(int cmstId)
        {
            if (DataValidate.CheckDataSetNotEmpty(MyOrganizationDAL.SelectOrganizationByCmstId(cmstId)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckCmstName(string cmstName)
        {
            if (DataValidate.CheckDataSetNotEmpty(MyOrganizationDAL.SelectOrganizationByCmstName(cmstName)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public FeedbackInfomation GetOrganizationByID(int cmstID)
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyOrganizationDAL.SelectOrganizationByID(cmstID);
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

        public FeedbackInfomation GetAllOrganization()
        {
            FeedbackInfomation fi = new FeedbackInfomation();
            try
            {
                fi.Result = MyOrganizationDAL.SelectAllOrganizationEntity();
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
