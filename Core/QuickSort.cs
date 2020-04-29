using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class QuickSort
    {
        public static int[] Sort(int[] numbers)
        {
            Sort(numbers, 0, numbers.Length - 1);
            return numbers;
        }
        public static void Sort(int[] numbers, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = start;
            int left = start + 1;
            int right = end;

            while (right >= left)
            {
                if (numbers[left] > numbers[pivot] && numbers[right] < numbers[pivot])
                {
                    swap(numbers, left, right);
                }

                if (numbers[left] <= numbers[pivot])
                {
                    left++;
                }
                if (numbers[right] >= numbers[pivot])
                {
                    right--;
                }                
            }
            swap(numbers, pivot, right);
            bool leftSubarrayIsSmaller = right - 1 - start < end - (right + 1);
            if (leftSubarrayIsSmaller)
            {
                Sort(numbers, start, right - 1);
                Sort(numbers, right + 1, end);
            } else
            {
                Sort(numbers, right + 1, end);
                Sort(numbers, start, right -1);
            }
        }

        private static void swap(int[] numbers, int left, int right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;

        }
    }
}
