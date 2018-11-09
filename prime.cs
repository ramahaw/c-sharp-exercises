
//find out if the entered number is primary or not primary. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Prime
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            if (number == 1 || number == 0)
            {
                Console.WriteLine("Primary");
            }
            else
            {
                while (i < number)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Not Primary");
                        break;
                    }
                    else
                    {
                        i++;
                        if (number - i == 1)
                        {
                            Console.WriteLine("Primary");
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
