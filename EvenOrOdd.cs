
// ‏Find out if the entered number is odd or even by using -2‏

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to know if it's even or odd:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 1)
            {
                number -= 2;
            }

            if (number == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
