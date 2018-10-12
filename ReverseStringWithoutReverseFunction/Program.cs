using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringWithoutReverseFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String To Reverse:");
            string str = Console.ReadLine();

            string reverseStr = "";
            int length;

            length = str.Length - 1;
            while (length >= 0)
            {
                reverseStr = reverseStr + str[length];
                length--;
            }

            Console.WriteLine(reverseStr);
            Console.ReadLine();

        }
    }
}
