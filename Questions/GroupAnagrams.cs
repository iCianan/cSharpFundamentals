using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class GroupAnagrams
    {
        public static List<List<string>> find(List<string> strings)
        {
            var anagrams = new Dictionary<string, List<string>>();
            foreach (string anagram in strings)
            {
                var charArray = anagram.ToCharArray();
                Array.Sort(charArray);
                var sortedWord = new string(charArray);
                if (anagrams.ContainsKey(sortedWord))
                {
                    anagrams[sortedWord].Add(anagram);
                }
                else
                {
                    anagrams[sortedWord] = new List<string>() { anagram };
                }
            }
            return anagrams.Values.ToList();
        }
    }
}
