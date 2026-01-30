using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите раудс малой оси");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите раудс большой оси");
            int b = Convert.ToInt32(Console.ReadLine());
            double p = a * b * 3.14;
            double s = 2 * 3.14 * Math.Sqrt(0.5 * (a * a + b * b));
            Console.WriteLine("Периметр = " + p);
            Console.WriteLine("Периметр = " + s);
        }
    }
}
