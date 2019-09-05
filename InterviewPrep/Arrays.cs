using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Arrays
    {
        public int[] TwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        if (array[i] > array[j])
                        {
                            return new int[] { array[j], array[i] };
                        }
                        else
                        {
                            return new int[] { array[i], array[j] };

                        }
                    } 
                }
            }
            return new int[] { };
        }
    }
}
