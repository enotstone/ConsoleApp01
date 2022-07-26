using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            LineU equ = new LineU ();

            Console.WriteLine("Для 0 = xk + b, введите b:");
            equ.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Для 0 = xk + b, введите k:");
            equ.k = Convert.ToDouble(Console.ReadLine());
            equ.Root();

            Console.ReadKey();
        }
        struct LineU
        {
            public double k;
            public double b;
            public void Root()
            {
                Console.WriteLine("0 = xk + b, X = {0}", -b/k);
            }
        }
    }
}
