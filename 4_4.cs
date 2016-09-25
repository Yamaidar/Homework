using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool log = false;
            long n = 1;
            while (log == false)
            {
                Console.WriteLine("Введите число, оканчивающееся на 5");
                n = long.Parse(Console.ReadLine());
                if (n % 10 == 5)
                {
                    log = true;
                }
                else Console.WriteLine("Это число не оканчивается на 5");
            }
            n = (n / 10) * (n / 10 + 1) * 100 + 25;
            Console.WriteLine("n^2 = " + n);
        }
    }
}
