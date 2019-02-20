using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewPage
{
    public partial class DataGridViewEx : DataGridView
    {
        public delegate bool CmdKeyHandler(ref Message msg, Keys keyData);
        public CmdKeyHandler CmdKeyCallBack;
        public DataGridViewEx()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //UpdateStatus.Continue;  
            UpdateStyles();
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            if (this.EditingControl is DataGridViewTextBoxEditingControl)
            {
                KeyEventArgs e = new KeyEventArgs(((Keys)((int)m.WParam)) | Control.ModifierKeys);
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    return false;
                }
            }
            return base.ProcessKeyPreview(ref m);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);           
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (CmdKeyCallBack != null)
            {
                return CmdKeyCallBack(ref msg, keyData);
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
}
