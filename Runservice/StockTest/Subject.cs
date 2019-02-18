namespace StockModelData

{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public bool SubjectType { get; set; }
    }

    public class SubjectTab
    {
        public const string SUB_ID = "Sub_Id";
        public const string SUB_NAME = "Sub_Name";
        public const string SUB_TYPE = "Sub_Type";
    }
}