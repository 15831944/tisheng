using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCommon
{
    public class Tips
    {
        public const string SERVER = "服务器";
        public const string DB = "数据库";
        public const string IP = "IP";
        public const string ERROR_FORMAT = "格式不正确";
        public const string ERROR_EMPTY = "不能为空";

        public const string DB_CONNECTTEST_FAILED = "数据库连接测试失败";
        public const string DB_CONNECTTEST_SUCCESS = "数据库连接测试成功";
        public const string DB_ERROR = "数据库错误";

        public const string REDISCLUSTER_CONNECTTEST_FAILED = "Redis集群连接测试失败";
        public const string REDISCLUSTER_CONNECTTEST_SUCCESS = "Redis集群连接测试成功";

        public const string CAR_BINDED = "车辆登记单已绑定";
        public const string CAR_REPEATE = "车辆登记单重复";
        public const string BIND_SUCCESS = "绑定成功";
        public const string BIND_FAILED = "绑定失败";
        public const string UNBIND_SUCCESS = "解绑成功";
        public const string UNBIND_FAILED = "解绑失败";
        public const string CAUNIQFLAG_GET_FAILED = "获取唯一项失败";
        public const string CAUNIQFLAG_BINDED = "该证书已被绑定";
        public const string SETTING_SUCCESS = "设置成功";
        public const string TEMPORARY_SUCCESS = "暂存成功";
        public const string TEMPORARY_FAILED = "暂存失败";
        public const string REVIEW_SUCCESS = "复核成功";
        public const string REVIEW_FAILED = "复核失败";
        public const string SAVE_SUCCESS = "保存成功";
        public const string SAVE_FAILED = "保存失败";
        public const string INSERT_SUCCESS = "插入成功";
        public const string INSERT_FAILED = "插入失败";
        public const string UPDATE_SUCCESS = "更新成功";
        public const string UPDATE_FAILED = "更新失败";
        public const string DELETE_SUCCESS = "删除成功";
        public const string DELETE_FAILED = "删除失败";
        public const string CHECK_SUCCESS = "审核成功";
        public const string CHECK_FAILED = "审核失败";
        public const string CONFIRM_SUCCESS = "确认成功";
        public const string CONFIRM_FAIlED = "确认失败";
        public const string QUERY_FAILED = " 查询失败";
        public const string GET_FAILED = "获取失败";
        public const string SUBMIT_SUCCESS = "提交成功";
        public const string SUBMIT_FAILED = "提交失败";
        public const string CANCELSUBMIT_SUCCESS = "取消提交成功";
        public const string CANCELSUBMIT_FAILED = "取消提交失败";
        public const string RETURN_SUCCESS = "退回成功";
        public const string RETURN_FAILED = "退回失败";
        public const string WITHDRAW_SUCCESS = "撤回成功";
        public const string WITHDRAW_FAILED = "撤回失败";
        public const string INVALID_SUCCESS = "作废成功";
        public const string INVALID_FAILED = "作废失败";
        public const string END_SUCCESS = "结束成功";
        public const string END_FAILED = "结束失败";
        public const string RESTART_SUCCESS = "重启成功";
        public const string RESTART_FAILED = "重启失败";
        public const string CUSTOMER_UPDATE_COMPANY_FAILED = "客户公司信息更新失败";
        public const string CUSTOMER_UPDATE_CONNECTOR_FAILED = "客户联系人信息更新失败";
        public const string CUSTOMER_UPDATA_SEAL_FAILD = "客户印章信息更新失败";
        public const string CUSTOMER_UPDATE_FAILED = "客户信息更新失败";

        public const string CUSTOMER_DELETE_COMPANY_FAILED = "客户公司信息删除失败";
        public const string CUSTOMER_DELETE_CONNECTOR_FAILED = "客户联系人信息删除失败";
        public const string CUSTOMER_DELETE_SEAL_FAILD = "客户印章信息删除失败";
        public const string CUSTOMER_DELETE_FAILED = "客户信息删除失败";

        public const string CUSTOMER_INSERT_COMPANY_FAILED = "客户公司信息插入失败";
        public const string CUSTOMER_INSERT_CONNECTOR_FAILED = "客户联系人信息插入失败";
        public const string CUSTOMER_INSERT_SEAL_FAILD = "客户印章信息插入失败";
        public const string CUSTOMER_INSERT_FAILED = "客户信息插入失败";
        public const string CUSTOMER_NAME_REPEATE = "客户名称重复";
        public const string CUSTOMER_CODE_REPEATE = "客户代码重复";

        public const string CUSTOMER_STORAGE_INSERT_FAILED = "客户分库信息插入失败";
        public const string CUSTOMER_STORAGE_UPDATE_FAILED = "客户分库信息更新失败";

        public const string CUSTOMER_SERVICES_INSERT_FAILED = "客户服务信息插入失败";
        public const string CUSTOMER_SERVICES_UPDATE_FAILED = "客户服务信息更新失败";

        public const string QERUY_RESULT_EMPTY = "没有查询结果";

        public const string QUERY_SEAL_EMPTY = "没有客户或公司的盖章信息";


        public const string LOGIN_NO_USER_OR_ERROR = "用户名密码错误!!!";
        public const string LOGIN_NO_ROLE = "该用户还未分配角色!!!";
        public const string LOGIN_SUCCESS = "登录成功";
        public const string LOGIN_FAILED = "登录失败";
        public const string LOGIN_OPERATOR_ONLINED = "登录失败，该用户已上线";
        public const string LOGOUT_SUCCESS = "退出成功";
        public const string LOGOUT_FAILED = "退出失败";
        public const string ACCOUNT_PASSWORD_ERROR = "用户名或密码错误";


        public const string STORAGE_INSERT_FAILED = "分库插入失败";
        public const string STORAGE_UPDATE_FAILED = "分库更新失败";
        public const string STORAGE_REPEATED = "分库重复";

        public const string DEPART_INSERT_FAILED = "部门插入失败";
        public const string DEPART_UPDATE_FAILED = "部门更新失败";
        public const string DEPART_REPEATED = "部门重复";

        public const string ROLE_INSERT_FAILED = "角色插入失败";
        public const string ROLE_UPDATE_FAILED = "角色更新失败";
        public const string ROLE_REPEATED = "角色重复";

        public const string PERSON_INSERT_FAILED = "人员插入失败";
        public const string PERSON_UPDATE_FAILED = "人员更新失败";
        public const string PERSON_ACCOUNT_REPEATED = "人员账号重复";


        public const string GOODSCLASS_INSERT_FAILED = "物资类别插入失败";
        public const string GOODSCLASS_UPDATE_FAILED = "物资类别更新失败";
        public const string GOODSCLASS_REPEATED = "物资类别重复";

        public const string GOODSBREED_INSERT_FAILED = "品种插入失败";
        public const string GOODSBREED_UPDATE_FAILED = "品种更新失败";
        public const string GOODSBREED_REPEATED = "品种重复";

        public const string GOODSNAME_INSERT_FAILED = "品名插入失败";
        public const string GOODSNAME_UPDATE_FAILED = "品名更新失败";
        public const string GOODSNAME_REPEATED = "品名重复";

        public const string SPEC_INSERT_FAILED = "规格插入失败";
        public const string SPEC_UPDATE_FAILED = "规格更新失败";
        public const string SPEC_REPEATED = "规格重复";

        public const string MATERIAL_INSERT_FAILED = "材质插入失败";
        public const string MATERIAL_UPDATE_FAILED = "材质更新失败";
        public const string MATERIAL_REPEATED = "材质重复";

        public const string PRODUCT_INSERT_FAILED = "产品插入失败";
        public const string PRODUCT_UPDATE_FAILED = "产品更新失败";
        public const string PRODUCT_REPEATED = "产品重复";

        public const string AREA_INSERT_FAILED = "产地插入失败";
        public const string AREA_UPDATE_FAILED = "产地更新失败";
        public const string AREA_REPEATED = "产地重复";

        public const string INNOTICE_INSERT_FAILED = "入库通知插入失败";
        public const string INNOTICE_UPDATE_FAILED = "入库通知更新失败";
        public const string INNOTICE_QUERY_FAILED = "入库通知查询失败";
        public const string INNOTICEDETAIL_INSERT_FAILED = "入库通知明细插入失败";
        public const string INNOTICEDETAIL_UPDATE_FAILED = "入库通知明细更新失败";
        public const string INNOTICEDETAIL_QUERY_FAILED = "入库通知明细查询失败";

        public const string FROZENADNCANCEL_INSERT_FAILED = "冻结解冻插入失败";
        public const string FROZENADNCANCEL_UPDATE_FAILED = "冻结解冻更新失败";
        public const string FROZENADNCANCEL_QUERY_FAILED = "冻结解冻查询失败";
        public const string FROZENADNCANCELDETAIL_INSERT_FAILED = "冻结解冻明细插入失败";
        public const string FROZENADNCANCELDETAIL_UPDATE_FAILED = "冻结解冻明细更新失败";
        public const string FROZENADNCANCELDETAIL_QUERY_FAILED = "冻结解冻明细查询失败";

        public const string THROWIN_INSERT_FAILED = "投放单插入失败";
        public const string THROWIN_UPDATE_FAILED = "投放单更新失败";
        public const string THROWINDETAIL_INSERT_FAILED = "投放单明细插入失败";
        public const string THROWINDETAIL_UPDATE_FAILED = "投放单明细更新失败";
        public const string DIRECTIONALCUSTOMER_INSERT_FAILED = "定向客户插入失败";
        public const string DIRECTIONALCUSTOMER_UPDATE_FAILED = "定向客户更新失败";
        public const string THROWIN_QUERY_FAILED = "查询投放单失败";

        public const string SALE_QUERY_FAILED = "查询销售单失败";
        public const string SALE_UPDATE_FAILED = "更新销售单失败";
        public const string SALEDETAIL_UPDATE_FAILED = "更新销售明细失败";

        public const string CHECKOUT_INSERT_FAILED = "核销单插入失败";
        public const string CHECKOUT_UPDATE_FAILED = "核销单更新失败";
        public const string CHECKOUTDETAIL_INSERT_FAILED = "核销明细插入失败";
        public const string CHECKOUTDETAIL_UPDATE_FAILED = "核销明细更新失败";

        public const string CUSTOMERFUND_INSERT_FAILED = "客户资金插入失败";
        public const string CUSTOMERFUND_UPDATE_FAILED = "客户资金更新失败";
        public const string CUSTOMERFUND_UNCORRECT = "客户账户不正确";


        public const string MONEY_INSERT_FAILED = "资金流向插入失败";

        public const string CHECKOUT_BIGGER_SALE = "核销金额不能大于销售金额";

        public const string BILLOFLADING_CHECKPWDFAILED = "网提单密码验证失败!!!";
        public const string BILLOFLADING_CHECKPWDSUCCESS = "网提单密码验证成功!!!";
        public const string BILLOFLADING_PWD_UNSAME = "网提密码不一致!!!";
        public const string BILLOFLADING_STATUS_UPDATEFAILED = "网提状态更新失败!!!";

        public const string CHECKOUT_GET_FAILED = "获取核销单失败";

        public const string RETURNBACK_INSERT_FAILED = "退货单插入失败!!!";
        public const string RETURNBACKDETAIL_INSERT_FAILED = "退货明细插入失败!!!";
        public const string RETURNBACK_UPDATE_FAILED = "退货单更新失败!!!";
        public const string RETURNBACKDETAIL_UPDATE_FAILED = "退货明细更新失败!!!";
        public const string RETURNBACK_QUERY_FAILED = "查询退货单失败";
        public const string RETURNBACKDETAIL_QUERY_FAILED = "查询退货明细失败";

        public const string RECYCLE_INSERT_FAILED = "回收单插入失败!!!";
        public const string RECYCLEDETAIL_INSERT_FAILED = "回收明细插入失败!!!";
        public const string RECYCLE_UPDATE_FAILED = "回收单更新失败!!!";
        public const string RECYCLEDETAIL_UPDATE_FAILED = "回收明细更新失败!!!";

        public const string RECYCLEDETAIL_NUM_OVER = "回收数量超出可回收量!!!";
        public const string RECYCLEDETAIL_WEIGHT_OVER = "回收重量超出可回收量!!!";

        public const string OPENMARKET_UPDATE_FAILED = "更细开市信息失败!!";

        public const string THROWINDETAIL_UPDATEPRICE_FAILED = "投放单价格更新失败!!!";
        public const string NO_NEED_UPDATE_DATA = "没有更新的数据";

        public const string NO_DATA = "没有数据";
        public const string CREATE_FUND_ACCOUNT = "创建资金账户失败";
        public const string ORDER_CHANGE_PRICE_FAILED = "订单改价失败";
        public const string ORDER_CHANGE_PRICE_OVERDUE = "订单过期";

        public const string REVERSE_SUCCESS = "冲销成功!!!";
        public const string REVERSE_FAILED = "冲销失败!!!";

        public const string DESERIALIZEPARA_FAILED = "反序列化参数失败!!!";

        public const string IMPORT_SUCCESS = "导入成功!!!";
        public const string IMPORT_FAILED = "导出失败!!!";

        public const string CHARGE_NORMAL = "已缴费!!!";
        public const string CHARGE_EMPTY = "未缴费!!!";
    }
}
