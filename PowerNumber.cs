using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerNumber
{
    class PowerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a power:");
            int power = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            while (power > 0)
            {
                result *= number;
                power--;
            }
            Console.WriteLine("the result is:" + result);
            Console.ReadKey();
        }
    }
}
