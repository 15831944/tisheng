using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
            this.comboBox1.SelectedText = "大庆";
            this.comboBox1.SelectedItem = this.comboBox1.Items[1];
            var a = this.comboBox1.SelectedValue;
        }
    }
}
