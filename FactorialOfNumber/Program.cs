using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("INVALID INPUT");
            else if (num == 0)
                Console.WriteLine("FACTORIAL= 1");
            else
                Fact(num);

            Console.ReadLine();
        }

        public static void Fact(int num)
        {
            int i, factorial = 1;

            for (i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("FACTORIAL= " + factorial);
        }
    }
}
