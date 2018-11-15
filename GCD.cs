
// this program will give you the GCD for any number.

using System;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 = number1 - number2;
                }
                else
                {
                    number2 = number2 - number1;
                }
            }
            Console.WriteLine("The GCD is: " + number1);
            Console.ReadKey();
        }
    }
}
