using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCommon
{
   public enum STATUS_ADAPTER
    {
        DB_CONNECT_NORMAL = 0,
        DB_CONNECT_FAILD = 1,
        DB_ERROR = 2,
        IP_NORMAL = 3,
        IP_EMPTY = 4,
        IP_FORMAT = 5,
        QUERY_NORMAL = 6,
        QUERY_ERROR = 7,
        INSERT_NORMAL = 8,
        INSERT_ERROR = 9,
        SAVE_SUCCESS = 10,
        SAVE_FAILED = 11,
        DEl_SUCCESS = 12,
        DEL_FAILED = 13,
        QUERY_NODATA = 14,
        CHECK_SUCCESS = 15,
        CHECK_FAILED = 16,
        CANCEL_CHECK_SUCCESS = 17,
        CANCEL_CHECK_FAILED = 18,
        LOGIN_SUCCESS = 19,
        LOGIN_FAILED = 20,
        CHECK_PWD_SUCCESS = 21,
        CHECK_PWD_FAILED = 22,
        BIND_SUCCESS = 23,
        BIND_FAILED = 24,
        TEMPORARY_SUCCESS = 25,
        TEMPORARY_FAILED = 26,
        REVIEW_SUCCESS = 27,
        REVIEW_FAILED = 28,
        CONFIRM_SUCCESS = 29,
        CONFIRM_FAILED = 30,
        QUERY_REPEAT = 31,
        RedisCluster_CONNECT_NORMAL = 32,
        RedisCluster_CONNECT_FAILD = 33,
        UPDATE_SUCCESS = 34,
        UPDATE_ERROR = 35,
        LOGOUT_SUCCESS = 36,
        LOGOUT_FAILED = 37,
        REVERSE_SUCCESS = 38,
        REVERSE_FAILED = 39,
        ACCOUNT_PASSWORD_ERROR = 40,
        DESERIALIZEPARA_FAILED = 41,
        IMPORT_SUCCESS = 42,
        IMPORT_FAILED = 43,
        SUBMIT_SUCCESS = 44,
        SUBMIT_FAILED = 45,
        CANCELSUBMIT_SUCCESS = 46,
        CANCELSUBMIT_FAILED = 47,
        RETURN_SUCCESS = 48,
        RETURN_FAILED = 49,
        INVALID_SUCCESS = 50,
        INVALID_FAILED = 51,
        END_SUCCESS = 52,
        END_FAILED = 53,
        RESTART_SUCCESS = 54,
        RESTART_FAILED = 55,
        WITHDRAW_SUCCESS = 56,
        WITHDRAW_FAILED = 57,
        CHARGE_NORMAL = 58,
        CHARGE_EMPTY = 59
    
}
}
