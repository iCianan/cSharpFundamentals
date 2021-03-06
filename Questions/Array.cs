﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Arrays
    {
        public static int iterativeArraySum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int arraySumDelegate(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int lastNumber = numbers[numbers.Length -1];
            int allButLastSum = iterativeArraySum(numbers[0..(numbers.Length - 1)]);
            return lastNumber + allButLastSum;
        }
        public static bool ValidateSubsequence(int[] array, int[] sequence)
        {
            //Time O(n)
            //Space O(n)
            var results = new List<int>();
                int i = 0;
                int j = 0;
                while (i < array.Length && j < sequence.Length)
                {
                    if (array[i] == sequence[j])
                    {
                        results.Add(sequence[j]);
                        i++;
                        j++;
                    }
                    else i++;
                }
                if (j != sequence.Length) return false;
                int k = 0;
                int l = 0;
                while (k < results.Count)
                {
                    if (results[k] == sequence[l])
                    {
                        k++;
                        l++;
                    }
                    else return false;
                }
                return true;            
        }

        //Time O(n)
        //Space O(1)
        public static bool AlgoValidateSubsequence(List<int> array, List<int> sequence)
        {
            int i = 0;
            int j = 0;
            while (i < array.Count && j < sequence.Count)
            {
                if (array[i] == sequence[j])
                {
                    i++;
                    j++;
                }
                else 
                {
                    array.RemoveAt(i);
                }
                
            }

            while (i < array.Count)
            {
                array.RemoveAt(i);
            }

            if (j != sequence.Count) return false;


            int k = 0;
            int l = 0;
            while (k < array.Count)
            {
                if (array[k] == sequence[l])
                {
                    k++;
                    l++;
                }
                else return false;
            }
            return true;
        }
    }
}