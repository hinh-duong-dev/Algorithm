using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { -2, 45, 0, 11, -9 };
            Console.WriteLine(string.Join(", ", data));

            Sorting.SelectionSort(data);
            Console.WriteLine(string.Join(", ", data));

            int[] array = { 2, 4, 0, 1, 9 };

            Console.WriteLine(string.Join(", ", array));
            int x = 4;

            int result = Searching.LinearSearch(array, x);

            if (result == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Element found at index: " + result);
            }
              
            Console.ReadLine();
        }
    }
}
