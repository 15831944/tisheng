using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public class TextBoxExPH : TextBox, IModify
    {
        private bool isModified;
        private string _oldText;

        public TextBoxExPH()
        {
            this.TextChanged += (m, n) =>
            {
                if (this.Text == "")
                {
                    Graphics g = Graphics.FromHwnd(this.Handle);
                    g.DrawString(this.PlaceHolderStr, this.Font, new SolidBrush(Color.LightGray), 0, 0);
                    g.Dispose();
                }
            };

        }
        public String PlaceHolderStr { get; set; }

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


        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            base.WndProc(ref m);
            const int WM_PAINT = 0xF;


            if (m.Msg == WM_PAINT)
            {
                if (this.Text == "" && this.PlaceHolderStr != "")
                {
                    Graphics g = Graphics.FromHwnd(this.Handle);
                    g.DrawString(this.PlaceHolderStr, this.Font, new SolidBrush(Color.LightGray), 0, 0);
                    g.Dispose();
                }
            }


        }

    }
}
