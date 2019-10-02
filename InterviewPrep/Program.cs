using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 99, 24, 2, 8, 6, 23, 11, 6, 65, 78, 47 };
           int[] newNums = MergeSort.Sort(nums);
            foreach (var item in newNums)
            {
                Console.WriteLine(item);
            }
            Search search = new Search();
            bool results = search.IsUserNameTaken("john");
           int yep = search.BinarySearch(nums, 78);
           int nope = search.BinarySearch(nums, 8);
            Console.WriteLine(yep);
            Console.WriteLine(nope);
            yep = search.BinarySearchRecursive(nums, 78, 0, nums.Length - 1);
            nope = search.BinarySearchRecursive(nums, 8, 0, nums.Length - 1);
            Console.WriteLine(yep);
            Console.WriteLine(nope);
        }
    }
}
