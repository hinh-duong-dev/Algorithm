using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public static class Searching
    {
        public static int LinearSearch(int[] array, int x)
        {
            int size = array.Length;

            // Going through array sequencially
            for (int i = 0; i < size; i++)
            {
                if (array[i] == x)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int x)
        {
            int low = 0;
            int high = array.Length - 1;
            // Repeat until the pointers low and high meet each other
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == x)
                    return mid;

                if (array[mid] < x)
                    low = mid + 1;

                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}
