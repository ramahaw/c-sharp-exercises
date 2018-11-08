using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class prime
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i < x)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("not prime");
                    break;
                }
                else
                {
                    i++;
                    if (x-i==1)
                    {
                        Console.WriteLine("prime");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
