using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class TopKFrequentWords
    {
        // Given a list of reviews, a list of keywords and an integer k.
        // Find the most popular k keywords in order of most to least frequently mentioned.

        public static List<string> FrequentWords(string[] words, int k)
        {
            var results = new List<string>();
            var count = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (count.ContainsKey(words[i]))
                {
                    count[words[i]]++;
                }
                else
                {
                    count.Add(words[i], 1);
                }                
            }
            
  
            return results;
        }
    }
}
