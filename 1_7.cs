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
            Console.WriteLine("Введите длины 3 отрезков");  
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if ((x + y > z) && (x + z > y) && (y + z > x))
            { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
