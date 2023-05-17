using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, z;

            Console.WriteLine("Введите m: ");
            string mm = Console.ReadLine();
            double m = Convert.ToDouble(mm);

            Console.WriteLine("Введите n: ");
            string nn = Console.ReadLine();
            double n = Convert.ToDouble(nn);

            Console.WriteLine("Введите a: ");
            string aa = Console.ReadLine();
            double a = Convert.ToDouble(aa);

            Console.WriteLine("Введите b: ");
            string bb = Console.ReadLine();
            double b = Convert.ToDouble(bb);

            Console.WriteLine("Введите c: ");
            string cc = Console.ReadLine();
            double c = Convert.ToDouble(cc);

            if (m > n)
            {
                a1 = m;
            }
            else if (n > m) 
            {
                a1 = n;
            }
            else
            {
                a1 = n * Math.Cos(n);
            }

            if (m < 5) 
            {
                b1 = a; 
            }
            else if (m == 5)
            {           
                b1 = b;
            }
            else
            {
                b1 = c;
            }

            double a11 = Math.Pow(a1, 2.0);

            z = Math.Pow(a11, 1.0 / 3.0) + b1 + Math.Exp(a1) - Math.Cos(b1);

            Console.WriteLine($"результата = {Math.Round(z)}");
            Console.ReadLine();

        }
    }
}
