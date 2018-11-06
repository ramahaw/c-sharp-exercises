// Max Number
// First, tell me how many numbers you want to enter.‏
// Then, enter the numbers.
// After that, the program will print the biggest number.
‏
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());

            while (--n > 0)
            {
                Console.Write("Enter number: ");
                int tempNum = Convert.ToInt32(Console.ReadLine());
                if (tempNum > maxNum)
                {
                    maxNum = tempNum;
                }
            }

            Console.WriteLine("The biggest number is: " + maxNum);
            Console.ReadKey();
        }
    }
}
