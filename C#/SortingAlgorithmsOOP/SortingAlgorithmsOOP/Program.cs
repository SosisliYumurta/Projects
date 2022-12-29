using System;

namespace SortingAlgorithmsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[500];

            SortManager sort1 = new SortManager();
            sort1.BubbleSortAscending(arr);
            sort1.BubbleSortDescending(arr);

            sort1.InsertionSortAscending(arr);

            sort1.SelectionSortAscending(arr);
            sort1.SelectionSortDescending(arr);
            
        }
    }
}
