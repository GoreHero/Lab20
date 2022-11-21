using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        delegate double MyDeligate(double r);
        static void Main(string[] args)
        {
            double r = InputR();
            MyDeligate mydeligate = Leght;
            mydeligate += Square;
            mydeligate += Volume;
            mydeligate(r);
            Console.ReadKey();

        }
        static double InputR()
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            return r;
        }
        static double Leght(double r)
        {
            double d= 2*Math.PI*r;
            Console.WriteLine($"Длина = {d}");
            return d;
        }
        static double Square(double r)
        {
            double s = Math.PI*r*r;
            Console.WriteLine($"Площадь = {s}");
            return s;
        }
        static double Volume(double r)
        {
            double v = (4*Math.PI*Math.Pow(r,3))/3;
            Console.WriteLine($"Объем = {v}");
            return v;
        }

    }
}
