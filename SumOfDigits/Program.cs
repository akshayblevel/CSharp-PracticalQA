using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum;

            Console.WriteLine("Please enter the number");
            n = int.Parse(Console.ReadLine());
            sum = 0;

            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine("the sum of digits is " + sum);
            Console.ReadLine();

        }
    }
}
