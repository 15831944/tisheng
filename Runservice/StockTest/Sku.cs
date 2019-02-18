using System.ComponentModel.DataAnnotations;

 namespace StockModelData

{
    public class Sku
    {
        public int? AuxID;


        public int ProductID;

        [StringLength(32)] public string SignNum;

        public int? SignTypeID;
        public int SkuID;


        [StringLength(128)] public string SkuName;

        [StringLength(32)] public string Spare;
    }

    public class SkuTab
    {
        public const string SKU_ID = "Sku_Id";
        public const string SKU_PRO_ID = "Sku_Pro_Id";
        public const string SKU_STY_ID = "Sku_Sty_Id";
        public const string SKU_SIGNNUM = "Sku_SignNum";
        public const string SKU_SPARENO = "Sku_SpareNo";
        public const string SKU_SAT_ID = "Sku_Sat_Id";
        public const string SKU_NAME = "Sku_Name";
    }
}