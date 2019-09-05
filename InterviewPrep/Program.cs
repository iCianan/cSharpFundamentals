using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            int[] numbers = { 15, 8, 62, 1, -1 };
            int targetSum = 2;
            arrays.TwoNumberSum(numbers, targetSum);
            arrays.BubbleSort(numbers);
        }
    }
}
