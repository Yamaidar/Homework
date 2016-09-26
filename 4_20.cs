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
            int x, y, z;
            for (int n = 3; n <= 20; n++)
            {
                for (int m = n + 1; m <= 21; m++)
                {
                    if (2 * m * n + 2 * m * m == 1000)
                    {
                        Console.WriteLine(2 * m * n + "   " + (m * m - n * n) + "   " + (m * m + n * n));
                        Console.WriteLine("a*b*c = " + (2 * m * n * (m * m - n * n) * (m * m + n * n)));
                    }
                }
            }
        }
    }
}
