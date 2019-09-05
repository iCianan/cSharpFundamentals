using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            int[] numbers = { 5, 8, 6, -4 };
            int targetSum = 2;
            arrays.TwoNumberSum(numbers, targetSum);
        }
    }
}
