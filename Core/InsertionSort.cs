using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers;

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0 && numbers[j - 1] > numbers[j]; j--)
                {
                    swap(j, j - 1, numbers);
                }
            }
            return numbers;
        }

        private static void swap(int i, int j, int[] numbers)
        {
            int temp = numbers[j];
            numbers[j] = numbers[i];
            numbers[i] = temp;
        }
    }
}
