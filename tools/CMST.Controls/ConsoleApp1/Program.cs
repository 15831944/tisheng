using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataHelper.SetConnStr("127.0.0.1", "1433", "TestDB", "sa", "123");
            SqlConnection conn = SqlDataHelper.GetConnection();
            string sqlstr = "select top 100000 * from TestTab";
            double d = 0;


            //            d = 0;
            //             for (int i = 0; i < 100; i++)
            //             {
            //                 Stopwatch sw = new Stopwatch();
            // 
            //                 sw.Start();
            //                 conn.Open();
            //                 DataSet ds = SqlDataHelper.ExecuteDataSet(conn, CommandType.Text, sqlstr);
            //                 conn.Close();
            //                 sw.Stop();
            //                 d = d + sw.ElapsedMilliseconds;
            //                 Console.WriteLine($"ds{i}:" + sw.Elapsed.TotalMilliseconds);
            //             }
            //             Console.WriteLine("ds Total:" + (d / 100.0).ToString());
            //             Console.WriteLine();

            d = 0;
            for (int i = 0; i < 100; i++)
            {
                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                conn.Open();
                DataTable dt = SqlDataHelper.ExecuteDataTable(conn, "SelectTest", CommandType.StoredProcedure, null);
                conn.Close();
                sw2.Stop();

                d = d + sw2.ElapsedMilliseconds;
                Console.WriteLine($"dt{i}:" + sw2.Elapsed.TotalMilliseconds);
            }
            Console.WriteLine("dt Total:" + (d / 100.0).ToString());
            Console.WriteLine();


            d = 0;
            for (int i = 0; i < 100; i++)
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                conn.Open();
                DataSet ds = SqlDataHelper.ExecuteDataSet(conn, CommandType.StoredProcedure, "SelectTest");
                conn.Close();
                sw.Stop();
                d = d + sw.ElapsedMilliseconds;
                Console.WriteLine($"ds{i}:" + sw.Elapsed.TotalMilliseconds);
            }
            Console.WriteLine("ds Total:" + (d / 100.0).ToString());
            Console.WriteLine();

         

//             d = 0;
//             for (int i = 0; i < 100; i++)
//             {
//                 Stopwatch sw2 = new Stopwatch();
//                 sw2.Start();
//                 conn.Open();
//                 DataTable dt = SqlDataHelper.ExecuteDataTable(conn, sqlstr, CommandType.Text, null);
//                 conn.Close();
//                 sw2.Stop();
// 
//                 d = d + sw2.ElapsedMilliseconds;
//                 Console.WriteLine($"dt{i}:" + sw2.Elapsed.TotalMilliseconds);
//             }
//             Console.WriteLine("dt Total:" + (d / 100.0).ToString());
//             Console.WriteLine();

            //             d = 0;
            //             for (int i = 0; i < 10; i++)
            //             {
            //                 Stopwatch sw3 = new Stopwatch();
            //                 sw3.Start();
            //                 conn.Open();
            //                 DataTable dtt = new DataTable();
            //                 SqlCommand cmd = new SqlCommand(sqlstr, conn);
            //                 SqlDataReader sdr = cmd.ExecuteReader();
            //                 dtt.Load(sdr);
            //                 conn.Close();
            //                 sw3.Stop();
            // 
            //                 d = d + sw3.ElapsedMilliseconds;
            //                 Console.WriteLine($"sdr{i}:" + sw3.Elapsed.TotalMilliseconds);
            //             }
            //             Console.WriteLine("sdr Total:" + (d / 10.0).ToString());
            //             Console.Read();
        }
    }
}
