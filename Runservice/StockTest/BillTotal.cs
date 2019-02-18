using System.Collections.Generic;

 namespace StockModelData

{
    public class BillTotal
    {
        public BillTotal()
        {
            brs = new List<BillRecord>();
        }

        public long TotalID { get; set; }
        public int BillType { get; set; }
        public long BillID { get; set; }

        public List<BillRecord> brs { get; set; }
    }

    public class BillTotalTab
    {
        public const string BTO_ID = "Bto_Id";
        public const string BTO_Type = "Bto_Type";
        public const string BTO_BILLID = "Bto_BillID";
    }
}