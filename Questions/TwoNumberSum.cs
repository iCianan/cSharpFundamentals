using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class TwoNumberSum
    {
        //Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. If any two numbers in the input array sum up to the target sum,
        //the function should return them in an array. If no two numbers sum up to the target sum, the function should return an empty array. Assume that there will be at most one pair of numbers
        // summing up to the target pair.
        public int[] BurteForce(int[] numbers, int targetSum)
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
    }
}
