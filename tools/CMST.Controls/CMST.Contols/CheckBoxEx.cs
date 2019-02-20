using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public class CheckBoxEx : CheckBox, IModify
    {
        private bool isModified;
        public bool IsModified
        {
            get { return isModified; }
        }


        private bool _oldChecked = false;

        public void Reset()
        {
            isModified = false;
            _oldChecked = isModified;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Checked != this._oldChecked)
            {
                isModified = true;
            }
            else
            {
                isModified = false;
            }
            base.OnCheckedChanged(e);
        }
    }
}
