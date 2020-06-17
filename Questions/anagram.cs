using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class anagram
    {
        // O(n) T | O(n) S
        public static bool find(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = i; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        second = second.Remove(j, j);
                        i++;
                        j--;
                    }
                }
            }
            return second.Length == 0;
        }
        // O(n) T | O(n) S
        public static bool findBetter(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }
            var hash1 = new Dictionary<char, int>();
            var hash2 = new Dictionary<char, int>();

            foreach (var item in first)
            {
                if (hash1.ContainsKey(item))
                {
                    hash1[item] = hash1[item] += 1;
                }
                else hash1[item] = 1;
            }
            foreach (var item in second)
            {
                if (hash2.ContainsKey(item))
                {
                    hash2[item] = hash2[item] += 1;
                }
                else hash2[item] = 1;
            }
            foreach (var item in hash1)
            {
                if (!hash2.ContainsKey(item.Key))
                {
                    return false;
                }
                if (hash2[item.Key] != hash1[item.Key])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
