using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            // This program will give you the multiplication table of any number you enter

            Console.WriteLine("Please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = x * i;
                Console.WriteLine(i + " * " + x + " = " + result);
            }
        }
    }
}
