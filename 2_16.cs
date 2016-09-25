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
            long x = long.Parse(Console.ReadLine());
            int max = 0, k = 0;
            string s = "";
            do
            {
                if (x % 2 == 0)
                {
                    k += 1;
                }
                else
                {
                    k = 0;
                }
                if (k > max)
                {
                    max = k;
                }
                s = Convert.ToString(x % 2) + s;
                x = x / 2;
            }
            while (x >= 1);
            Console.WriteLine(max);
        }
    }
}
