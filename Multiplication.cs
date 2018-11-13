using System;
namespace multiplication
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you want to know the multiplication table for him");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = x * i;
                Console.WriteLine(i + " * " + x + " = " + result);
            }
        }
    }
}
