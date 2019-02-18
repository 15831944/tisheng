using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StockCommon
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
        public static bool CheckDataSetNotEmpty(System.Data.DataSet ds)
        {
            if (ds == null)
                return false;
            if (ds.Tables.Count <= 0)
                return false;
            if (ds.Tables[0].Rows.Count <= 0)
                return false;
            return true;
        }

        public static int? GetValueOrNullInt(object p)
        {
            if (Convert.IsDBNull(p))
            {
                return null;
            }
            else
            {
                return (int?)p;
            }
        }

        public static long? GetValueOrNullLong(object p)
        {
            if (Convert.IsDBNull(p))
            {
                return null;
            }
            else
            {
                return (long?)p;
            }
        }

        public static DateTime? GetValueOrNullDateTime(object p)
        {
            if (Convert.IsDBNull(p))
            {
                return null;
            }
            else
            {
                return (DateTime?)p;
            }
        }

        public static T GetValueOrNull<T>(object p) where T : class
        {
            if (Convert.IsDBNull(p))
            {
                return null;
            }
            else
            {
                return (T)p;
            }
        }

        public static decimal? GetValueOrNullDecimal(object p)
        {
            if (Convert.IsDBNull(p))
            {
                return null;
            }
            else
            {
                return (decimal?)p;
            }
        }


    }
}
