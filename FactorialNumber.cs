using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class FactorialNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positve number to get its factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(number + "!= " + result);
            Console.ReadKey();
        }
    }
}
