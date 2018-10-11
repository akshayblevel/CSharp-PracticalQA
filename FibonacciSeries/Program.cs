using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = 0, secondNo = 1;
            Console.WriteLine("ENTER FIBONACCI SERIES OF NTH TERM: ");
             int n = int.Parse(Console.ReadLine());
            Console.WriteLine("First Number={0},Second Number={1}", firstNo, secondNo);
            Fib(n);
            Console.ReadLine();
        }

        public static void Fib(int n)
        {
            int i, currentNo, firstNo = 0, secondNo = 1;
            for (i = 0; i <= (n - 3); i++)
            {
                currentNo = firstNo + secondNo;
                firstNo = secondNo;
                secondNo = currentNo;
                Console.WriteLine(currentNo);
            }
        }
    }
}
