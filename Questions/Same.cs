using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Same
    {
        // Write a function called same, which accepts two arrays.
        // The function should return true if every value in the array has its 
        // corresponding value squared in the second array. The frequency of values must 
        // the same. 
        // O(n) T | O(n) S
        public static bool isSame(int[] first, int[] second)
        {
            var counter = new Dictionary<int, int>();
            var counter2 = new Dictionary<int, int>();
            for (int i = 0; i < first.Length; i++)
            {
                if (counter.ContainsKey(first[i]))
                {
                    counter[first[i]] = counter[first[i]] += 1;
                }
                else counter.Add(first[i], 1);
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (counter2.ContainsKey(second[i]))
                {
                    counter2[second[i]] = counter2[second[i]] += 1;
                }
                else counter2.Add(second[i], 1);
                    
            }

            foreach (var item in counter)
            {
                if (!counter2.ContainsKey(item.Key* item.Key))
                {
                    return false;
                }

                if (counter2[item.Key * item.Key] != counter[item.Key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
