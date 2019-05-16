using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProb4
{
    class SelectionSort<T>
    {
        public static void selectionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                T min = array.ElementAt(i);
                int minId = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    // array[j] < min
                    if (array[j].CompareTo(min) < 0)
                    {
                        min = array[j];
                        minId = j;
                    }
                }
                // swapping
                T temp = array[i];
                array[i] = min;
                array[minId] = temp;
            }
        }
    }
}
