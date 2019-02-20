using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public class UIOp
    {
        public static bool IsModify(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control is IModify)
                {
                    if (((IModify)control).IsModified)
                        return true;
                }
                else if (control.Controls.Count > 0)
                {
                    return IsModify(control);
                }
            }
            return false;
        }

        public static void Reset(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c.Controls.Count > 0)
                    Reset(c);
                if (c is IModify)
                {
                    (c as IModify).Reset();
                }
            }
        }
    }
}
