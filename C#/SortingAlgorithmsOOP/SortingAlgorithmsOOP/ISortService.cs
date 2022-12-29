using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmsOOP
{
    interface ISortService
    {
        int[] BubbleSortAscending(int[] arr);
        int[] BubbleSortDescending(int[] arr);

        

        int[] InsertionSortAscending(int[] arr);
        int[] InsertionSortDescending(int[] arr);

        

        int[] SelectionSortAscending(int[] arr);
        int[] SelectionSortDescending(int[] arr);

        

    }
}
