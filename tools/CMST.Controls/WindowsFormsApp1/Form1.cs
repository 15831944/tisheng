using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModify(this))
            {
                MessageBox.Show("数据修改过11");
            }
         //tanchu
        }

        private bool IsModify(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control.Controls.Count > 0)
                    return IsModify(control);
                if (control is IModify)
                {
                    if (((IModify)control).IsModified)
                        return true;
                }
            }
            return false;
        }

        private void Reset(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c.Controls.Count > 0)
                    Reset(c);
                if(c is IModify)
                {
                    (c as IModify).Reset();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Reset(this);
        }
    }
}
