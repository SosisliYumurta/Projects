using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmsOOP
{
    class SortManager : ISortService
    {
        static int temp = 0;
        static DateTime start;
        static TimeSpan timesSpend;
        static long swaps = 0;
        static long comp = 0;



        public static int[] generateRandomArr(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(5000);
            }
            return arr;
        }
        public void PrintArray(int[] arr, int nth)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % nth == 1)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public int[] BubbleSortAscending(int[] arr)
        {
            generateRandomArr(arr);

            temp = 0;
            swaps = 0;
            comp = 0;
            start = DateTime.Now;


            Console.WriteLine("Ascending Bubble Sort has started.");


            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                        swaps++;
                    }
                    comp++;
                }
            }

            timesSpend = DateTime.Now - start;

            Console.WriteLine("Calculation time is= {0} \nSwaps= {1} Comparisons= {2} ", timesSpend, swaps, comp);
            PrintArray(arr, 50);



            return arr;
        }

        public int[] BubbleSortDescending(int[] arr)
        {
            generateRandomArr(arr);

            temp = 0;
            swaps = 0;
            comp = 0;
            start = DateTime.Now;

            Console.WriteLine("Descending Bubble Sort has started.");


            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaps++;
                    }
                    comp++;
                }
            }

            timesSpend = DateTime.Now - start;

            Console.WriteLine("Calculation time is= {0} \nSwaps= {1} Comparisons= {2}", timesSpend, swaps, comp);
            PrintArray(arr, 50);


            return arr;
        }

        public int[] InsertionSortAscending(int[] arr)
        {
            generateRandomArr(arr);

            swaps = 0;
            comp = 0;
            start = DateTime.Now;

            Console.WriteLine("Ascending Insertion Sort has started.");
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    swaps++;
                    comp++;
                }
                arr[j + 1] = key;
                comp++;
            }



            timesSpend = DateTime.Now - start;
            Console.WriteLine("Calculation time is= {0} \nSwaps= {1} Comparisons= {2}", timesSpend, swaps, comp);
            PrintArray(arr, 50);
            return arr;

        }

        public int[] InsertionSortDescending(int[] arr)
        {
            return null;
        }

        public int[] SelectionSortAscending(int[] arr)
        {
            generateRandomArr(arr);

            start = DateTime.Now;
            swaps = 0;
            comp = 0;

            Console.WriteLine("Ascending Selection Sort has started.");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                        
                    }
                        
                    comp++;
                }

                swaps++;
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            timesSpend = DateTime.Now - start;
            Console.WriteLine("Calculation time is= {0} \nSwaps= {1} Comparisons= {2}", timesSpend, swaps, comp);
            PrintArray(arr, 50);
            return arr;
        }

        public int[] SelectionSortDescending(int[] arr)
        {
            temp = 0;
            comp = 0;
            swaps = 0;
            start = DateTime.Now;
            int index;

            Console.WriteLine("Descending Selection Sort has started.");

            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[index])
                        index = j;
                    comp++;
                }

                if (index != i)
                {
                    temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    swaps++;
                }
            }
            timesSpend = DateTime.Now - start;

            Console.WriteLine("Calculation time is= {0} \nSwaps= {1} Comparisons= {2}", timesSpend, swaps, comp);
            PrintArray(arr, 50);

            return arr;
        }
    }
}
