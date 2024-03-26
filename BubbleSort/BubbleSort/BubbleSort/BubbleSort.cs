using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSort
    {
        static bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 < array.Length)
                {
                    if (array[i] > array[i + 1])
                    {
                        return false;
                    }
                }
           
            }
            return true;
        }

        public static int[] Sort(int[] unsortedArray)
        {
            bool isSorted = IsSorted(unsortedArray);

            while (!isSorted)
            {
                for (int i = 0; i < unsortedArray.Length; i++)
                {
                    if (i + 1 < unsortedArray.Length)
                    {
                        if (unsortedArray[i] > unsortedArray[i + 1])
                        {
                            (unsortedArray[i], unsortedArray[i + 1]) = (unsortedArray[i + 1], unsortedArray[i]);
                        }
                    }
                  
                }
                isSorted = IsSorted(unsortedArray);
            }
            return unsortedArray;
        }
    }
}
