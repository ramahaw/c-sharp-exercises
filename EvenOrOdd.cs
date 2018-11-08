using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            while (x > 1)
            {
                x = x - 2;
            }
            if (x == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }
    }
}
