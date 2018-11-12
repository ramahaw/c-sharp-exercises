using System;

namespace Prime
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to know if it's primary or not");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1 || number == 0)
            {
                Console.WriteLine("Primary");
            }
            else
            {
                int i = 2;
                while (i < number)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Not Primary");
                        break;
                    }
                    else
                    {
                        if (number - i == 1)
                        {
                            Console.WriteLine("Primary");
                        }
                    }
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
