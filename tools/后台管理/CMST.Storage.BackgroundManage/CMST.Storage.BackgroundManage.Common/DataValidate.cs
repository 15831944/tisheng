using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Common
{
    public class DataValidate
    {
        public static FeedbackInfomation ValidateIpAddress(string ipaddress)
        {
            var fi = new FeedbackInfomation();
            var validipregex =
                new Regex(
                    @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            if (ipaddress == "")
            {
                fi.ErrorStatus = STATUS_ADAPTER.IP_EMPTY;
                fi.FeedbackMessage = Tips.IP + Tips.ERROR_EMPTY;
                fi.Result = "";
                return fi;
            }
            if (!validipregex.IsMatch(ipaddress.Trim()))
            {
                fi.ErrorStatus = STATUS_ADAPTER.IP_FORMAT;
                fi.FeedbackMessage = Tips.IP + Tips.ERROR_FORMAT;
                fi.Result = "";
                return fi;
            }

            fi.ErrorStatus = STATUS_ADAPTER.IP_NORMAL;
            fi.FeedbackMessage = "";
            fi.Result = "";
            return fi;
        }
        public static bool CheckDataSetNotEmpty(DataSet ds)
        {
            if (ds == null)
                return false;
            if (ds.Tables.Count <= 0)
                return false;
            if (ds.Tables[0].Rows.Count <= 0)
                return false;
            return true;
        }
}
}
