using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojmian
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj Swiecie");
            String wspA, wspB, wspC;
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Podaj A,B, C");
            wspA = Console.ReadLine();
            wspB = Console.ReadLine();
            wspC = Console.ReadLine();
            Console.WriteLine("A=" + wspA  + "\t B=" + wspB + "\t C=" + wspC);
            a = Convert.ToDouble(wspA);
            b = Convert.ToDouble(wspB);
            c = Convert.ToDouble(wspC);
            delta = 4 * b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("delta ujemna brak pierwiastków");
            }
            else if (delta == 0)
            {
                double x1_2;
                x1_2 = -b/2*a;
                Console.WriteLine("delta równa zero");
            }
            else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2= " + x2);
            }
            Console.ReadKey();
        }
    }
}
