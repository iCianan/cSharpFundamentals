using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Arrays
    {
        public string[] Days { get; set; }
        public string[] Months { get; set; }
        public int[] Numbers { get; set; }
        public Arrays()
        {
            Numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Days = new string[] {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            Months = new string[] {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "June",
                "July",
                "Aug",
                "Sept",
                "Oct",
                "Nov",
                "Dec"
            };

        }
        public void ListDaysInOrder()
        {
            foreach (string day in Days)
            {
                Console.WriteLine(day);
            }
        }
        public void ReplaceAllDaysWithMonths()
        {

            for (int i = 0; i < Days.Length; i++)
            {

                Days[i] = Months[i];
                Console.WriteLine(Days[i]);
            }
        }
        public void ListNumbersBackwards()
        {
            for (int i = Numbers.Length - 1; i > 0; i--)
            {
                Console.WriteLine(Numbers[i]);
            }
        }
        public void ReadFromConsole()
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            for (int i = 0; i < number; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public bool IsSymmetrical(int[] array)
        {
            bool results = true;
            int end = array.Length - 1;

            for (int start = 0; start < end; start++)
            {
                if (array[start] != array[end])
                {
                    return false;
                }
                end--;
            }
            return results;
        }

        /*
        Write a function that takes in a non-empty array of distinct integers and an
        integer representing a target sum.If any two numbers in the input array sum
        up to the target sum, the function should return them in an array, in any
        order. If no two numbers sum up to the target sum, the function should return
        an empty array. 
        
        Note that the target sum has to be obtained by summing two different integers
        in the array; you can't add a single integer to itself in order to obtain the
        target sum.
            
        You can assume that there will be at most one pair of numbers summing up to
        the target sum.            
        */
        public int[] TwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        return new int[] { array[i], array[j] };
                    }
                }
            }
            return new int[] { };
        }

        public int[] TwoNumSumBetter(int[] array, int targetSum)
        {
            Dictionary<int, bool> cache = new Dictionary<int, bool>();

            foreach (var number in array)
            {
                int potentialMatch = targetSum - number;
                if (cache.ContainsKey(potentialMatch))
                {
                    return new int[] { potentialMatch, number };
                } 
                else
                {
                    cache[number] = true;
                }
            }
            return new int[] { };
        }

    }
}
