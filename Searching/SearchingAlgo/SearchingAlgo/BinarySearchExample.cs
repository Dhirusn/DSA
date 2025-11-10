using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    using System;

    public static class BinarySearchExample
    {
        public static int Search(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == value)
                    return mid;
                else if (array[mid] > value)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }

    }
}
