using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public static class MergeSort
    {
        public static int[] Sort(int[] numericArray)
        {
            if (numericArray.Length <= 1)
            {
                return numericArray;
            }
            int mid = numericArray.Length / 2;
            int[] left = Sort(numericArray.Take(mid).ToArray());
            int[] right = Sort(numericArray.Skip(mid).ToArray());
            return Merge(left, right);

        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> results = new List<int>();
            int i = 0;
            int j = 0;
            while (i < left.Length && j < right.Length)
            {
                if (right[j] >= left[i])
                {
                    results.Add(left[i++]);
                }
                else
                {
                    results.Add(right[j++]);
                }
            }
            while (i < left.Length)
            {
                results.Add(left[i++]);
            }

            while (j < right.Length)
            {
                results.Add(right[j++]);
            }

            return results.ToArray(); ;
        }
    }
}
