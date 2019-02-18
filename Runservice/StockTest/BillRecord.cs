using System;
using System.Collections.Generic;

namespace StockModelData
{
    public class BillRecord
    {
        public BillRecord()
        {
            bds = new List<BillDetail>();
        }

        public long RecordID { get; set; }
        public long TotalID { get; set; }
        public DateTime RecordTime { get; set; }

        public List<BillDetail> bds { get; set; }
    }

    public class BillRecordsTab
    {
        public const string BRE_ID = "Bre_Id";
        public const string BRE_BTO_ID = "Bre_Bto_Id";
        public const string BRE_TIME = "Bre_Time";
    }
}