using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task1
{
    internal class Program
    {
        //delegate int MyDelegate(int a, int b);
        delegate int MyDelegate (int v1,int v2);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method2;
            //myDelegate-=Method1;
            //if(myDelegate!=null)
            //    myDelegate();
            //MyDelegate myDelegate = new MyDelegate(Method5);
            //myDelegate?.Invoke(3, 4);
            //Action action = Method1;
            //action();
            MyDelegate myDelegate = (v1,v2)=>//v1+v2
            {
                Console.WriteLine("Method 5");
                return v1 + v2;
            };
            myDelegate (1,1);
            
            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
        static int Method5(int v1, int v2)
        {
            Console.WriteLine("Method5");
            return v1 + v2;
        }
    }
}
