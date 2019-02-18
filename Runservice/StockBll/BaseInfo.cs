using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockModelData;
using StockDal;

namespace StockBll
{
    public class BaseInfo

    {
        public static List<BillType> BillTypeList;
        public static List<SignType> SignTypeList;
        public static List<Subject> SubjectList;
        public static List<BillStatus> BillStatusList;
        public static List<SkuAuxType> SkuAuxTypeList;
        BaseInfoDAL MyBaseInfoDAL = new BaseInfoDAL();
        SubjectDAL MySubjectDAL = new SubjectDAL();
        BillTypeDAL MyBillTypeDAL = new BillTypeDAL();
        SignTypeDAL MySignTypeDAL = new SignTypeDAL();
        SkuAuxTypeDAL MySkuAuxTypeDAL = new SkuAuxTypeDAL();

        public static class BillTypes
        {
            public const string INSTORE_NOTICE = "入库通知单";
            public const string INSTORE_BILL = "入库单";
            public const string OUTSTORE_NOTICE = "发货通知单";
            public const string OUTSTORE_BILL = "发货单";

            public const string TRANSPOSITION_BILL = "移位单";
            public const string ADJUST_BILL = "调整单";
            public const string FROZEN_BILL = "冻结解冻单";
            public const string TRANSFER_BILL = "过户单";
            public const string PROCESSING_BILL = "加工单";
            public const string ChangeCustomerOutBill = "对调发货单";
            public const string STOCKTAKING_BILL = "盘点单";
        }

        public class SubjectTypes
        {
            public const string IN_NOTICE = "入库通知";
            public const string ACCEPTING = "待验收";
            public const string AVALIABLE = "可用库存";
            public const string OUT_NOTICE = "发货通知";
            public const string SHIPPING = "正在发";
            public const string SHIPPED = "已出库";
            public const string FROZEN = "冻结";
            public const string LIEN = "留置";
        }



        public class SignTypes
        {
            public const string CARNO = "车号";
            public const string BATNO = "批号";
            public const string INNOTICENO = "入库通知单号";
            public const string INSTORENO = "入库单号";
            public const string TRANSFERNO = "过户单号";
        }

        public class BillStatuses
        {
            public const string STATUS_TEMPORARY = "暂存";
            public const string STATUS_CHECKED = "已审核";
            public const string STATUS_FCHECKED = "已审核（实发）";
            public const string STATUS_PCHECKED2 = "复核（应发）";
            public const string STATUS_FCHECKED2 = "复核（实发）";
            public const string STATUS_CHECKED2 = "已复核";
            public const string STATUS_TEMPORARAY_PLAN = "暂存（应发）";
            public const string STATUS_TEMPORARAY_FACT = "暂存（实发）";
            public const string STATUS_SUBMITTED = "已提交";
            public const string STATUS_SUBMITTED_PLAN = "已提交（应发）";
            public const string STATUS_SUBMITTED_FACT = "已提交（实发）";
            public const string STATUS_SUBMIT = "已提交";
            public const string STATUS_TALLYCONFIRMATION = "理货确认";
            public const string STATUS_TEMP_SWAP = "暂存（对调发货）";
            public const string STATUS_CHECK_SWAP = "审核（对调发货）";
            public const string STATUS_OUTTOSWAP = "对调发货中";
            public const string STATUS_OUTTOSWAPED = "对调发货完成";
            public const string STATUS_Invalid = "已作废";
            public const string STATUS_REVERSE = "已冲销";
            public const string STATUS_CARREGISTER = "已入库";
            public const string STATUS_CARREGISTERSUCCESS = "已出库";
            public const string STATUS_CHARGESAVE = "已提交（费用）";
            public const string STATUS_CHARGECANCELSAVE = "取消提交（费用）";
            public const string STATUS_CHARGECHECK = "已审核（费用）";
            public const string STATUS_CHARGECANCELCHECK = "取消审核（费用）";
            public const string STATUS_NO_STOCKTAKED = "未盘点";
            public const string STATUS_PART_STOCKTAKED = "部分盘点";
            public const string STATUS_STOCK_FINISHED = "盘点完毕";
            public const string STATUS_STOCKTAKED = "已盘点";
            public const string STATUS_RESULT_SAME = "一致";
            public const string STATUS_RESULT_DIFFERENT = "不一致";
            public const string STATUS_WRITEOFF = "冲销";

        }

        public void LoadBaseInfo()
        {
            BillStatusList = MyBaseInfoDAL.SelectAllBillStatusList();
            SubjectList = MySubjectDAL.SelectAllSubjectEntityList();
            BillTypeList = MyBillTypeDAL.SelectAllBillTypeEntity();
            SignTypeList = MySignTypeDAL.SelectSignTypeEntityList();
            SkuAuxTypeList = MySkuAuxTypeDAL.SelectSkuAuxTypeEntityList();
        }



        public static R FindBy<T, W, R>(W w, List<T> t, string p1, string p2) where T : class
        {
            T tt = t.Find(m => m.GetType().GetProperty(p1).GetValue(m).ToString() == w.ToString());
            return (R)tt.GetType().GetProperty(p2).GetValue(tt);
        }


        /// <summary>
        /// 描述：通过业务名称返回业务类型ID
        /// 作者：谢茂林
        /// 编写时间：2017-11-08 10:29
        /// </summary>
        /// <param name="name">业务名称</param>
        /// <returns>返回业务单据类型ID</returns>
        public static int FindBillTypeIDByName(string name)
        {
            return BillTypeList.Find(m => m.BillTypeName == name).BillTypeID;
        }

        /// <summary>
        /// 描述：通过业务ID返回业务类型名称
        /// 作者：谢茂林
        /// 编写时间：2017-11-08 10:29
        /// </summary>
        /// <param name="id">业务名称</param>
        /// <returns>返回业务单据类型名称</returns>
        public static string FindBillTypeNameByID(int id)
        {
            return BillTypeList.Find(m => m.BillTypeID == id).BillTypeName;
        }

        /// <summary>
        /// 描述：通过单据状态名称查询单据状态ID
        /// 作者：谢茂林
        /// 编写时间：2017-11-08 10:29
        /// </summary>
        /// <param name="name">业务状态名称</param>
        /// <returns>业务状态ID</returns>
        public static int FindBillStatusIDByName(string name)
        {
            return BillStatusList.Find(m => m.BillStatusName == name).BillStatusId;
        }

        /// <summary>
        /// 描述：通过单据ID查询单据状态名称
        /// 作者：谢茂林
        /// 编写时间：2017-11-08 10:29
        /// </summary>
        /// <param name="id">状态ID</param>
        /// <returns>返回状态名称</returns>
        public static string FindBillStatusNameByID(int id)
        {
            return BillStatusList.Find(m => m.BillStatusId == id).BillStatusName;
        }

        /// <summary>
        /// 描述：通过科目名称和科目类型学返回科目类型ID
        /// 作者：谢茂林
        /// 编写时间：2017-11-8 10:29
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <param name="type">0：仓储方，1：客户方</param>
        /// <returns>标记类型ID</returns>
        public static int FindSubjectID(string subjectName, bool type)
        {
            return SubjectList.Find(m => m.SubjectName == subjectName && m.SubjectType == type).SubjectID;
        }

        /// <summary>
        /// 描述：通过标记名称返回标记类型ID
        /// 作者：谢茂林
        /// 编写时间：2017-11-8 10:29
        /// </summary>
        /// <param name="signTypeName">标记名称</param>
        /// <returns>标记类型ID</returns>
        public static int FindSignTypeID(string signTypeName)
        {
            return SignTypeList.Find(m => m.SignTypeName == signTypeName).SignTypeID;
        }

        /// <summary>
        /// 描述：通过标记类型ID返回标记名称
        /// 作者：谢茂林
        /// 编写时间：2017-11-8 10:29
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>返回标记名称</returns>
        public static string FindSignTypeName(int Id)
        {
            return SignTypeList.Find(m => m.SignTypeID == Id).SignTypeName;
        }

        /// <summary>
        /// 描述：通过辅助类型ID返回辅助名称
        /// 作者：谢茂林
        /// 编写时间：2017-11-8 10:29
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>返回辅助名称</returns>
        public static int FindAuxTypeID(string auxTypeName)
        {
            return SkuAuxTypeList.Find(m => m.AuxTypeName == auxTypeName).AuxTypeID;
        }

        /// <summary>
        /// 描述：通过辅助类型ID返回辅助名称
        /// 作者：谢茂林
        /// 编写时间：2017-11-8 10:29
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>返回辅助名称</returns>
        public static string FindAuxTypeName(int id)
        {
            return SkuAuxTypeList.Find(m => m.AuxTypeID == id).AuxTypeName;
        }



    }
}
