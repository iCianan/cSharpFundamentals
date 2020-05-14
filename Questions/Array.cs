using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Arrays
    {
        public static bool ValidateSubsequence(int[] array, int[] sequence)
        {
            int[] results = new int[sequence.Length];
            //Check if second array only contains calues from first array
            int i = 0;
            int j = 0;
            while (i < array.Length && j < sequence.Length)
            {
                if (array[i] == sequence[j])
                {
                    results[j] = sequence[j];
                    i++;
                    j++;
                }
                else
                {
                    i++;
                }
            }
            //if second array contains values not in the first array return false
            if (j != sequence.Length)
            {
                return false;
            }

            // Now check that the ordering of the second array matches the ordering of the first array.

            int k = 0;
            int l = 0;
            while (k < results.Length)
            {
                if (results[k] == sequence[l])
                {
                    k++;
                    l++;
                }
                //if ordering is different return false

                else
                {
                    return false;
                }
            }
            //if we get to the end return true
            return true;

        }
    }
}