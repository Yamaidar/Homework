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
            while (log == false)
            {
                Console.WriteLine("Введите 6-значное число");
                int x = Console.ReadLine();
                if (x >= 1000000 || x < 100000)
                {
                    Console.WriteLine("Это не 6-значное число");
                }
                else
                {
                    log = true;
                    if ((x % 10 == x / 100000) && ((x % 100 / 10) == (x / 10000 % 10)) && (x / 1000 % 10) == (x / 100 % 10))
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
            }
        }
    }
}
