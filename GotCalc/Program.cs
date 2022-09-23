using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d,v;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            c = a + b;
            v = a - b;
            Console.WriteLine("Результат: " + c);
            Console.WriteLine("Результат: " + v);
            Console.ReadKey(true);

        }
    }
}
