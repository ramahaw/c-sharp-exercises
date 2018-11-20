using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle

{
    class Triangle

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of lines:");
            int line = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                for (int stars = 0; stars <= i; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadKey();




        }
    }
}

