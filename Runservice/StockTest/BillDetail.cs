namespace StockModelData
{
    public class BillDetail
    {
        public long DetailID { get; set; }
        public long RecordID { get; set; }
        public long StockID { get; set; }
        public bool InOrDeType { get; set; }
        public decimal AN { get; set; }
        public int PN { get; set; }
    }

    public class BillDetailTab
    {
        public const string BDE_ID = "Bde_Id";
        public const string BDE_BRE_ID = "Bde_Bre_Id";
        public const string BDE_STO_ID = "Bde_Sto_Id";
        public const string BDE_TYPE = "Bde_Type";
        public const string BDE_ACCOUNTINGNUM = "Bde_AccountingNum";
        public const string BDE_PACKINGNUM = "Bde_PackingNum";
    }
}