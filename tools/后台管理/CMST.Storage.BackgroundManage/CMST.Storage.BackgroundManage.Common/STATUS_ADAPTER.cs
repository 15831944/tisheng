using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Common
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
        CHECK_PWD_FAILED = 22
    }
}
