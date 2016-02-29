using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEngine
{
    interface SortStrategy
    {
        void Sort(int[] list, View view);
    }
}
