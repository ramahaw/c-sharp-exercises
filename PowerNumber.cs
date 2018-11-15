using System;

namespace PowerNumber
{
    class PowerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a power:");
            int power = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            while (power > 0)
            {
                result *= number;
                power--;
            }
            Console.WriteLine("The result is:" + result);
            Console.ReadKey();
        }
    }
}
