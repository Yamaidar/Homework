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
            int max = a, min = a;
            while (a != 0)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max = " + max + ", min = " + min);
        }
    }
}
