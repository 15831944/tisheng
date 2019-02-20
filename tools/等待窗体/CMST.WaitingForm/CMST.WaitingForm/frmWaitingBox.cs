using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.WaitingForm
{
    public partial class frmWaitingBox : Form
    {
        private Thread MyWaitThread = null;
        public frmWaitingBox()
        {
            this.InitializeComponent();
            base.StartPosition = FormStartPosition.CenterScreen;
        }

        private void WaitThreadFunction()
        {
            base.ShowDialog();
            if (this.MyWaitThread != null)
            {
                if (this.MyWaitThread.ThreadState == ThreadState.Running)
                {
                    this.MyWaitThread.Abort();
                }
            }
        }

        private void WaitThreadFunctionEnd(object sender, EventArgs e)
        {
            base.Close();
            if (this.MyWaitThread != null)
            {
                if (this.MyWaitThread.ThreadState == ThreadState.Running)
                {
                    this.MyWaitThread.Abort();
                }
            }
        }
        public  void StartWait()
        {
            if (this.MyWaitThread != null)
            {
                if (this.MyWaitThread.ThreadState == ThreadState.Running)
                {
                    this.MyWaitThread.Abort();
                }
            }
            this.MyWaitThread = new Thread(new ThreadStart(this.WaitThreadFunction));
            this.MyWaitThread.Start();
        }

        public void EndWait()
        {
            if (this.MyWaitThread.ThreadState == ThreadState.Running)
            {
                this.MyWaitThread.Abort();
            }
            if (!base.IsDisposed)
            {
                Delegate EndWaiting = new EventHandler(this.WaitThreadFunctionEnd);
                object[] args = new object[2];
                base.BeginInvoke(EndWaiting, args);
            }
        }
    }
}
