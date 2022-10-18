namespace Algorithm
{
    public static class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            int length = array.Length;
            bool swapped;

            int count = 0;

            for (int i = 0; i < length - 1; i++)
            {
                swapped = false;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                        swapped = true;
                    }
                }

                count++;

                // IF no two elements were swapped by inner loop, then break
                if (!swapped)
                    break;
            }
        }

        public static void InsertionSort(int[] array)
        {
            int size = array.Length;
            for (int step = 1; step < size; step++)
            {
                int key = array[step];
                int j = step - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // Place key at after the element just smaller than it.
                array[j + 1] = key;
            }
        }

        public static void SelectionSort(int[] array)
        {
            int size = array.Length;

            for (int step = 0; step < size - 1; step++)
            {
                int min_idx = step;

                for (int i = step + 1; i < size; i++)
                {

                    // To sort in descending order, change > to < in this line.
                    // Select the minimum element in each loop.
                    if (array[i] < array[min_idx])
                    {
                        min_idx = i;
                    }
                }

                // put min at the correct position
                int temp = array[step];
                array[step] = array[min_idx];
                array[min_idx] = temp;
            }
        }
    }
}
