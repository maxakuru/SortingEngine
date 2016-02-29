using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEngine
{
    class MergeSort : SortStrategy
    {
        void SortStrategy.Sort(int[] list, View view)
        {
            mergesort(list, 0, list.Length-1, view);
            view.arrayToBars(list);
        }
        //recursively call mergesort
        void mergesort(int[] arr, int start, int end, View view)
        {
            //sleep for animation
            System.Threading.Thread.Sleep(20);

            if (start < end)
            {
                int mid = (end + start) / 2;
                mergesort(arr, start, mid, view);
                mergesort(arr, mid + 1, end, view);
                mergeArray(arr, start, mid, end, view);
            }
        }
        void mergeArray(int[] arr, int start, int mid, int end, View view)
        {
            //Create a temporary array for storing the merged array

            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            //whiles elements remain in first array
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            //while elements remain in second array
            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            //store temp array to list array
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++;
            }

            //paint updated array to view
            view.arrayToBars(arr);
        }
    }
}
