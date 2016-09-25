using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static bool simple(int a)
        {
            bool log = true;
            if (a == 2) { return true; }
            for (int i = 3; i < a; i += 2)
            {
                if (a % i == 0)
                {
                    log = false;
                }
            }
            return log;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            if (n % 2 == 0)
            {
                s += 2; ;
            }
            for (int j = 3; j <= n; j += 2)
            {
                if (simple(j) == true && n % j == 0)
                {
                    s += j;
                }
            }
            Console.WriteLine(s);
        }
    }
}
