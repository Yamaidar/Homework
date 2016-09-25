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
            // Числа вводятся по 1 в строку
            // Знаки должны чередоваться через 1
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            short k;
            int i = 2;
            bool log = true;
            long a = long.Parse(Console.ReadLine());
            if (a >= 0)
            {
                k = 1;
            }
            else
            {
                k = -1;
            }
            while (log == true && i <= n)
            {
                k *= -1;
                a = long.Parse(Console.ReadLine());
                if (a * k < 0)
                {
                    log = false;
                }
                ++i;
            }
            if (log == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
