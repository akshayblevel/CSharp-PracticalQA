using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String To Remove Duplicate Character:");
            string str = Console.ReadLine();


            string duplicate = string.Empty;
            string result = "";
            foreach (char value in str)
            {
                if (duplicate.IndexOf(value) == -1)
                {
                    duplicate += value;
                    result += value;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
