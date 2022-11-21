using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        delegate int MyDeligate(int a, int b);
        static void Main(string[] args)
        {
            //MyDeligate myDelegate = PowerAB;
            //int r = myDelegate(2, 10);
            //Console.WriteLine(r);

            //myDelegate = PowerBA;
            //r= myDelegate(2, 10);
            //Console.WriteLine(r);
            //Console.ReadKey();
            MyDeligate myDelegate = PowerAB;
            myDelegate+= PowerBA;
            myDelegate(2, 10);
            Console.WriteLine();

            Console.ReadKey();
        }

        static int PowerAB(int a, int b)
        {
            int r = (int)Math.Pow(a, b);
            Console.WriteLine(r);
            return r;
        }
            static int PowerBA(int a, int b)
        {
            int r = (int)Math.Pow(b, a);
            Console.WriteLine(r);
            return r;
        } 

    }
}
