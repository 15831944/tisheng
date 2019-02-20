using CMSTMsgBox;
using System.Data;
using System.Linq;

namespace CMST.Storage.Client.Proxy
{
    public class AuthorityHelper
    {
        public static bool JudgeAuthEmpty(DataTable dt)
        {
            if (dt == null)
            {
                MsgBox.ShowDialog("用户没有操作权限");
                return false;
            }
            return true;
        }

        public static bool JudgeAuthorityOperation(DataTable dt, string menu, string operation)
        {
            if (dt == null)
            {
                MsgBox.ShowDialog("用户没有操作权限");
                return false;
            }
            if (dt.AsEnumerable().Where(m => m.Field<string>("Ope_Name") == operation && m.Field<string>("Meu_Menu") == menu).Count() > 0)
            {
                return true;
            }
            MsgBox.ShowDialog("用户没有" + operation + "的操作权限");
            return false;
        }

        public static bool JudgeAuthorityMenu(DataTable dt, string menu)
        {
            if (dt == null)
            {
                MsgBox.ShowDialog("用户没有菜单权限");
                return false;
            }
            if (dt.AsEnumerable().Where(m =>m.Field<string>("Meu_Menu") == menu).Count() > 0)
            {
                return true;
            }
            MsgBox.ShowDialog("用户没有" + menu + "的菜单权限");
            return false;
        }
        public static bool JudgeAuthorityOperationWithOutTips(DataTable dt, string menu, params object[] operations)
        {
            if (dt == null)
            {

                return false;
            }

            foreach (var o in operations)
            {
                if (!(dt.AsEnumerable().Where(m => m.Field<string>("Ope_Name") == o.ToString() && m.Field<string>("Meu_Menu") == menu).Count() > 0))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
