using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEngine
{
    class SelectionSort : SortStrategy
    {
        void SortStrategy.Sort(int[] list, View view)
        {
            int i, j;
            //for the entire length of the list
            for (i = 0; i < list.Length; i++)
            {
                int min = i;
                for (j = i + 1; j < list.Length; j++)
                    if (list[j] < list[min]) min = j; //find min value
                //swap it with the first element of the unsorted list
                int temp = list[i];
                list[i] = list[min];
                list[min] = temp;

                //display each level of sort
                view.arrayToBars(list);
                //sleep for better animation
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
