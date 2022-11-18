using System;

namespace sortMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, -1, 5, 3, 11, -4, 10 };
            Console.Write("Bubble sort: ");
            BubbleSort(arr);
            Console.Write("Selection sort: ");
            SelectionSort(arr);
            Console.Write("Insertion sort: ");
            InsertionSort(arr);
        }
       static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            printArray(arr);
            return arr;
        }
        static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;

            
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            printArray(arr);
            return arr;
        }

        static int[] BubbleSort(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            printArray(arr);
            return arr;
        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
