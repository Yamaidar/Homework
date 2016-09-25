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
            string s = "";
            do
            {
                if (x % 16 < 10)
                {
                    s = Convert.ToString(x % 16) + s;
                }
                else
                {
                    if (x % 16 == 10)
                    {
                        s = "A" + s;
                    }
                    if (x % 16 == 11)
                    {
                        s = "B" + s;
                    }
                    if (x % 16 == 12)
                    {
                        s = "C" + s;
                    }
                    if (x % 16 == 13)
                    {
                        s = "D" + s;
                    }
                    if (x % 16 == 14)
                    {
                        s = "E" + s;
                    }
                    if (x % 16 == 15)
                    {
                        s = "F" + s;
                    }
                }
                x /= 16;
            }
            while (x >= 1);
            Console.WriteLine(s);
        }
    }
}
