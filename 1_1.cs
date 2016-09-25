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
            Console.WriteLine("Введите координаты клетки");  
            // Клетка (1;1) - черная
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x % 2 == 1)
            {
                if (y%2==1)
                {
                    Console.WriteLine("Black");
                }
                else
                {
                    Console.WriteLine("White");
                }
            }
            else
            {
                if (y%2==1)
                {
                    Console.WriteLine("White");
                }
                else
                {
                    Console.WriteLine("Black");
                }
            } 
        }
    }
}
