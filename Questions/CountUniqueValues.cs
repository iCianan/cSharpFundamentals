using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class CountUniqueValues
    {
        public static int CountLinq(int[] numbers)
        {
            var distinctNumbers = numbers.Distinct();
            return distinctNumbers.Count();
        }
        public static int CountSet(int[] numbers)
        {
            var hashSet = new HashSet<int>(numbers);
            return hashSet.Count;
        }

        public static int CountPointer(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int i = 0;
            int j = 1;
            int count = 0;
            while (j < numbers.Length)
            {   
                if (numbers[i] != numbers[j]) count++;
                i++;
                j++;
            }
            
            return count + 1;
        }
    }
}
