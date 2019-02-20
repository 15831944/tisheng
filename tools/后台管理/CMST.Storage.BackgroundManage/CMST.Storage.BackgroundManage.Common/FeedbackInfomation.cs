using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Common
{
    public class FeedbackInfomation
    {
        public object Result { get; set; }     
        public STATUS_ADAPTER ErrorStatus { get; set; }
        public string FeedbackMessage { get; set; }
    }
}
