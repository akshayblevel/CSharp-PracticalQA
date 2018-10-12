using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateIntegersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, int>();

            Console.WriteLine("NUMBER OF ELEMENTS IN ARRAY?");
            int totalElements = Int32.Parse(Console.ReadLine());

            int[] array = new int[totalElements];
            Console.WriteLine("INSERT ARRAY ELEMENTS");
            for (int i = 0; i < totalElements; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();

            //Using LINQ

            //int[] values = new[] { 1, 2, 3, 4, 5, 4, 4, 3 };

            //var groups = values.GroupBy(v => v);
            //foreach (var group in groups)
            //    Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());

        }
    }
}
