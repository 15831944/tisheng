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

namespace demo
{
    public partial class Form1 : Form
    {
        private Image im;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.im = Image.FromFile(@"C:\Users\Administrator\Desktop\2.gif");
            Thread t = new Thread(new ThreadStart(this.showback));
            t.IsBackground = !t.IsBackground;
            t.Start();
        }

        private void showback()
        {
            while (true)
            {
                this.BackgroundImage = this.im;
                Thread.Sleep(1000);
                this.BackgroundImage = null;
            }
        }
    }
}
