using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEngine
{
    class Model
    {
        int[] intArray;
        int _arraySize;

        public Model()
        {
            arraySize = 32; //initial value
        }

        public void reset(int size)
        {
            arraySize = size;
            intArray = new int[arraySize];
            Random a = new Random();
            List<int> randomList = new List<int>();
            int MyNumber = 0;
            randomList.Add(MyNumber);
            for (int i = 0; i < arraySize; i++)
            {
                while (randomList.Contains(MyNumber))
                {
                    MyNumber = a.Next(1, arraySize+1);
                }
                randomList.Add(MyNumber);
                intArray[i] = MyNumber;
            }
        }

        public int[] getUnSortedList()
        {
            return (intArray);
        }

        public int arraySize
        {
            get { return _arraySize; }
            set { _arraySize = value; }
        }
    }
}
