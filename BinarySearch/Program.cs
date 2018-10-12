using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBER OF ELEMENTS IN ARRAY?");
            int totalElements = Int32.Parse(Console.ReadLine());

            int[] searchArray = new int[totalElements];
            Console.WriteLine("INSERT ARRAY ELEMENTS");
            for (int i = 0; i < totalElements; i++)
            {
                searchArray[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("ENTER SEARCH ELEMENT");
            int searchElement = Int32.Parse(Console.ReadLine());

            Array.Sort(searchArray);

            int minIndex = 0;
            int maxIndex = totalElements - 1;
            while (minIndex <= maxIndex)
            {
                int mid = (minIndex + maxIndex) / 2;

                if (searchElement < searchArray[mid])
                    maxIndex = mid - 1;

                else if (searchElement > searchArray[mid])
                    minIndex = mid + 1;

                else if (searchElement == searchArray[mid])
                {
                    Console.WriteLine("SEARCH ELEMENT {0} FOUND AT LOCATION {1} AFTER SORTING\n", searchElement, mid + 1);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("SEARCH ELEMENT NOT FOUND");
            Console.ReadLine();
        }
    }
}
