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
            long k = long.Parse(Console.ReadLine());
            string s = "";
            do
            {
                if (k % 2 == 0)
                {
                    Console.Write(0);
                }
                s = Convert.ToString(k % 2) + s;
                k = k / 2;
            }
            while (k >= 1);
        }
    }
}
