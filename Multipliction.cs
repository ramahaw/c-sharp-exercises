using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    class Multipliction
    {
        static void Main(string[] args)
        {
            //this program give you the multipliction table of any number

            Console.WriteLine("Please enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10 ; i++)
            {
                int result = x * i;
                Console.WriteLine(i+ "*" +x+ "=" + result);
            }
        }
    }
}
