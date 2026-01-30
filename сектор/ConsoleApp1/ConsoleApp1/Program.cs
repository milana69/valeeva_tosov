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
            Console.WriteLine("Введите градус угла");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону");
            int r = Convert.ToInt32(Console.ReadLine());
            int p = r * r * o / 2;
            int s = r * o;
            Console.WriteLine("Периметр = " + p);
            Console.WriteLine("Площадь = " + s);

        }
    }
}
