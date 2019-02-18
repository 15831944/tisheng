using System;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShop BS = new BookShop();
            Thread T1 = new Thread(new ThreadStart(BS.sale));
            Thread T2 = new Thread(new ThreadStart(BS.sale));
            T1.Start();
            T2.Start();
            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }

    class BookShop
    {
        public int i = 1;
        public void sale()
        {
            lock(this)
            {
                int temp = i;
                if (temp > 0)
                {
                    Thread.Sleep(1000);
                    i -= 1;
                    Console.WriteLine("售出一本书，还剩余{0}", i);

                }
                else
                {
                    Console.WriteLine("NONONONO");
                }
            }
        }


    }
    class CallBack
    {
        private delegate void DoSomeCallBack(Type para);
        //声明回调
    }


}
