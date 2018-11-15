using System;
namespace multiplication
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to print its multiplication table:")
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = x * i;
                Console.WriteLine(i + " * " + x + " = " + result);
            }
        }
    }
}
