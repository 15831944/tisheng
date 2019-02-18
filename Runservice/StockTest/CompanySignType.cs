namespace StockModelData

{
    public class CompanySignType
    {
        public int CompanySignTypeID { get; set; }
        public int? SignTypeID { get; set; }
        public int CompanyID { get; set; }
        public bool IfUse { get; set; }
    }

    public class CompanySignTypeTab
    {
        public const string CST_ID = "Cst_Id";
        public const string CST_STY_ID = "Cst_Sty_Id";
        public const string CST_COM_ID = "Cst_Com_Id";
        public const string CST_IFUSE = "Cst_IfUse";
    }
}