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
            int a = int.Parse(Console.ReadLine());
            int max = a, k = 0;
            while (a != 0)
            {
                if (a > max)
                {
                    max = a;
                    k = 1;
                }
                if (a == max)
                {
                    k += 1;
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max = " + max + ", Встречается " + k + " раз");
        }
    }
}
