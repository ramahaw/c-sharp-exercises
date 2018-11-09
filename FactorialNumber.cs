using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class FactorialNumber
    {
        static void Main(string[] args)
        {
            int y = 1;
            Console.Write("x=  ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
                y = i * y;
            }
            Console.WriteLine("x! =" + y);
        }
    }
}
