using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    public static class LinearSearchExample
    {
        public static int Search(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)  // Stroll through the array
            {
                if (array[i] == value)
                {
                    return i;  // Found it! 0-based index for the win
                }
            }
            return -1;  // Tough luck
        }
    }
}
