using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public class TextBoxEx : TextBox, IModify
    {
        private bool isModified;
        private string _oldText;

        public bool IsModified
        {
            get { return isModified; }
        }
        public void Reset()
        {
            isModified = false;
            this._oldText = this.Text;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text != _oldText)
                this.isModified = true;
            else
                this.isModified = false;
            base.OnTextChanged(e);
        }
    }
}
