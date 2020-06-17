using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class sumZero
    {
        // O(n^2) T | O(1) T
        public static int[] Naive(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == 0)
                    {
                        return new int[] { array[i], array[j] };
                    }
                }
            }
            return new int[] { };
        }
        // O(n) T | O(1) T
        public static int[] Chad(int[] array)
        {
            var start = 0;
            var end = array.Length - 1;
            while (start < end)
            {
                int sum = array[start] + array[end];
                if (sum == 0)
                {
                    return new int[] { array[start], array[end] };
                }
                if (sum > 0)
                {
                    end--;
                }
                else start++;

            }
            return new int[] { };
        }
    }
}
