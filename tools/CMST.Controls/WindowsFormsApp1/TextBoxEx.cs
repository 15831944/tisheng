using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface IModify
    {
        bool IsModified { get; }

        void Reset();
    }

    public class TextBoxEx : TextBox, IModify
    {
        private bool isModified = false;
        private string OldText;

        public bool IsModified
        {
            get { return isModified; }
        }

        public void Reset()
        {
            isModified = false;
            this.OldText = this.Text;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text != OldText)
                this.isModified = true;
            else
                this.isModified = false;
            base.OnTextChanged(e);
        }

       
    } 
}
