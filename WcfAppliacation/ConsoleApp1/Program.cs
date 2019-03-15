using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class A
        {
            public A()
            {
                PrintFields();
            }
            public virtual void PrintFields() { }
        }
        class B : A
        {
            int x = 1;
            int y;
            public B()
            {
                y = -1;
            }
            public override void PrintFields()
            {
                Console.WriteLine("x={0},y={1}", x, y);
            }
            static void Main(string[] args)
            {
                for (int i = 0; i < MaoPao().Length; i++)
                {
                    Console.WriteLine(MaoPao()[i]);
                }
                B n= new B();
                n.PrintFields();
                Console.Read();

            }
            public static int[] MaoPao()
            {
                int[] SZ = { 12, 23, 13, 45, 26 };
                int temp = 0;
                for (int i = 0; i < SZ.Length - 1; i++)
                {
                    for (int j = i + 1; j < SZ.Length; j++)
                    {
                        if (SZ[i] > SZ[j])
                        {
                            temp = SZ[j];
                            SZ[j] = SZ[i];
                            SZ[i] = temp;

                        }

                    }

                }

                return SZ;
            }
        }
    }
}
