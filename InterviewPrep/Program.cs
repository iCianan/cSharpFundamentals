using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 2, 4, 6, 8, 11, 23, 44, 56, 65, 78, 99 };
            Search search = new Search();
            bool results = search.IsUserNameTaken("john");
           int yep = search.BinarySearch(nums, 78);
           int nope = search.BinarySearch(nums, 8);
            Console.WriteLine(yep);
            Console.WriteLine(nope);
        }
    }
}
