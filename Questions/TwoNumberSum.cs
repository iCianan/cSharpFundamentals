using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class TwoNumberSum
    {
        //Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. If any two numbers in the input array sum up to the target sum,
        //the function should return them in an array. If no two numbers sum up to the target sum, the function should return an empty array. Assume that there will be at most one pair of numbers
        // summing up to the target pair.
        public static int[] BurteForce(int[] numbers, int targetSum)
        {
            for (int first = 0; first < numbers.Length; first++)
            {
                for (int second = first + 1; second < numbers.Length; second++)
                {
                    if (numbers[first] + numbers[second] == targetSum)
                    {
                        int[] results = new int[] { numbers[first], numbers[second] };
                        return results.OrderBy(r => r).ToArray();
                    }
                }
            }
            return new int[] { };
        }
        public static int[] TwoNumberSum1(int[] array, int targetSum)
        {

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum && i != j) return new[] { i, j };
                }
            }
            return new int[] { };
        }
        public static int[] TwoNumberSum2(int[] array, int targetSum)
        {
            var cache = new Dictionary<int, int>();
            foreach (var item in array)
            {
                cache.Add(item, targetSum - item);
            }
            // {3: 7} {5: 5} {-4: 14} { 8: 2 } {11: -1} {1: 9} {-1: 11}, {6,4}

            foreach (var item in cache)
            {
                int possibleMatch = targetSum - item.Key;
                if (cache.ContainsKey(possibleMatch) && cache[possibleMatch] != item.Value)
                {
                    return new[] { item.Key, item.Value };
                }
            }
   
            return new int[] { };
        }
    }
}
