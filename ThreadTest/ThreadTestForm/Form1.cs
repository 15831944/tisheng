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

namespace ThreadTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义回调
        private delegate void setTextValueCallBack(int value);
        //声明回调
        private setTextValueCallBack setCallBack;

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //实例化回调
            setCallBack = new setTextValueCallBack(SetValue);
            //创建一个线程去执行这个方法:创建的线程默认是前台线程
            Thread thread = new Thread(new ThreadStart(Test));
            //Start方法标记这个线程就绪了，可以随时被执行，具体什么时候执行这个线程，由CPU决定
            //将线程设置为后台线程
            thread.IsBackground = true;
            thread.Start();
        }
        //实现从一个线程成功地访问另一个线程创建的空间，要使用C#的方法回调机制。
        private void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //使用回调
                textBox1.Invoke(setCallBack, i);
            }
        }

        /// <summary>
        /// 定义回调使用的方法
        /// </summary>
        /// <param name="value"></param>
        private void SetValue(int value)
        {
            this.textBox1.Text = value.ToString();
        }
        private void SerValue(string str)
        {
            this.textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text= string.Format($"****************btnSync_Click Start {Thread.CurrentThread.ManagedThreadId.ToString("00")} {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}***************");
            int j = 3;
            int k = 5;
            int m = j + k;
            for (int i = 0; i < 5; i++)
            {
                string name = string.Format($"btnSync_Click_{i}");
                this.DoSomethingLong(name);
            }
        }
        private void DoSomethingLong(string name)
        {
            textBox1.Text=string.Format($"****************DoSomethingLong {name} Start {Thread.CurrentThread.ManagedThreadId.ToString("00")} {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}***************");
            long lResult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lResult += i;
            }
           textBox1.Text+=string.Format($"****************DoSomethingLong {name}   End {Thread.CurrentThread.ManagedThreadId.ToString("00")} {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {lResult}***************");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"***************btnAsync_Click Start {Thread.CurrentThread.ManagedThreadId}");
            Action<string> action = this.DoSomethingLong;
            // 调用委托(同步调用)
            action.Invoke("btnAsync_Click_1");
            // 异步调用委托
            action.BeginInvoke("btnAsync_Click_2", null, null);
            Console.WriteLine($"***************btnAsync_Click End    {Thread.CurrentThread.ManagedThreadId}");
        }
    }


}
