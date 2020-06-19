using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class FindMissing
    {
        public static int Find_Set(int[] fullSet, int[] partialSet)
        {
            var misssing_item = fullSet.Except(partialSet).First();
            return misssing_item;

        }
        public static int Find(int[] first, int[] second)
        {
            int result = int.MaxValue;
            var firstCache = new Dictionary<int, int>();
            var secondCache = new Dictionary<int, int>();

            for (int i = 0; i < first.Length; i++)
            {
                if (firstCache.ContainsKey(first[i]))
                {
                    firstCache[first[i]] += 1;
                }
                else firstCache[first[i]] = 1;
            }

            for (int i = 0; i < second.Length; i++)
            {
                if (secondCache.ContainsKey(second[i]))
                {
                    secondCache[second[i]] += 1;
                }
                else secondCache[second[i]] = 1;
            }

            foreach (var item in first)
            {
                if (!secondCache.ContainsKey(item) || secondCache[item] != firstCache[item])
                {
                    result = item;
                }
            }
            return result;
        }
    }

}
