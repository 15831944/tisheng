using CMSTMsgBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MsgBox.ShowDialog("中华人民共和国万岁");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MsgBox.ShowDialog("你好世界，欢迎来到地球！！！","信息提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MsgBox.ShowDialog("你好世界，欢迎来到地球！！！", "信息提示",true);
            MsgBox.ShowDialog("你好世界，欢迎来到地球！！！", "信息提示",MsgBox.MyButtons.OKCancel,true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // MsgBox.ShowDialog("你好世界，欢迎来到地球！！！", "信息提示", MsgBox.MyButtons.OK, true);
            MsgBox.ShowDialog("你好世界，欢迎来到地球！！！", "信息提示", MsgBox.MyButtons.AbortRetryIgnore, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MsgBox.ShowDialog("你好世界，欢迎来到地球！！！", "信息提示", MsgBox.MyButtons.YesNo, true);
            if (result==DialogResult.No)
            {
                MsgBox.ShowDialog("你好世界，欢迎来到地球！！！", "信息提示", MsgBox.MyButtons.YesNoCancel, MsgBox.MyIcons.Exclamation);
            }
           
        }
    }
}
