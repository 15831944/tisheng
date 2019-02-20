using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage.Data
{
    public class OutboundWayEntity
    {
        public int OwaId { get; set; }
        public string OwaName { get; set; }
        public string OwaRemark { get; set; }
        public bool OwaIfUse { get; set; }
        public string OwaIfUse2 { get; set; }
    }
}
