using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 1.27;

            double x, a, y;

            string con;

            Console.Write("Введите значение x: ");

            con = Console.ReadLine();

            x = Convert.ToInt32(con);

            Console.Write("Введите значение a: ");

            con = Console.ReadLine();

            a = Convert.ToDouble(con);

            y = (Math.Sin(3 * x) + (Math.Pow(b, 2) + 1) * ((1 - Math.Cos(2 * a * x)) / (1 + Math.Cos(2 * a * x))) - 0.8 * Math.Pow(Math.E, a)) / (Math.Pow(a + 1, 1 / 3) + Math.Abs(Math.Log10(a * a * x) - 0.3 * (Math.Pow(b, 3) - a)) + Math.Acos(x));
            Console.WriteLine(Math.Round(y, 2));
            Console.WriteLine(Math.Sin(x));


            Console.WriteLine("Значение y= " + y);
            Console.ReadKey();
        }
    }
}
