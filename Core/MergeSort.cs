using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class MergeSort
    {
        public static int[] Sort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers;
            int mid = numbers.Length / 2;
            int[] left = Sort(numbers[..mid]);
            int[] right = Sort(numbers[mid..]);
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> results = new List<int>();
            int i = 0;
            int j = 0;
            while (i < left.Length && j < right.Length)
            {
                //acceptable for a white board interview only
                if (right[j] >= left[i]) results.Add(left[i++]);
                else results.Add(right[j++]);
            }
            while (i < left.Length) results.Add(left[i++]);
            while (j < right.Length) results.Add(right[j++]);
            return results.ToArray();
        }
    }
}
