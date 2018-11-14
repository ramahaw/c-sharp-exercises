using System;
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
