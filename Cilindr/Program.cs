using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindr
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;
            double R = 20, h = 10, V = 0, S = 0;
            V = pi * Math.Pow(R, 2) * h;
            Console.WriteLine("Объем цилиндра равен:" + V);
            S = 2 * pi * R * (R + h);
            Console.WriteLine("Площадь поверхности цилиндра равна:" + S);
            Console.ReadLine();
        }
    }
}
