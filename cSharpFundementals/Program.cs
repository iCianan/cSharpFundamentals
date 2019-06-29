using System;

namespace cSharpFundementals
{
  class Program
  {
    static void Main(string[] args)
    {
      //   Operators op = new Operators("JC","Penny", 54);
      // Console.WriteLine(op.FirstName);
      //  Console.WriteLine(op.A);

      //LinkedList ll = new LinkedList();
      //ll.insert(5);
      //Console.WriteLine(ll.Head);
      //ll.insert(15);
      //ll.insert(24);
      //ll.insert(75);
      //ll.insert(14);
      //ll.insert(37);

      //TreesAndGraphs.BinarySearchTree bst = new TreesAndGraphs.BinarySearchTree();
      //bst.Insert(5);


      //FizzBuzz fizz = new FizzBuzz();
      //int[] nums = { 2, 5, 12, 15, 20, 24, 30 }; // buzz fizzbuzz buzz fizz fizzbuzz
      //fizz.fizzBuzz(nums);
      string[] stringArray = { "tom", "t", "tomato", "toffee", "tommy" };
      LeetCode leetCode = new LeetCode();
      leetCode.LongestCommonPrefix(stringArray);
      leetCode.IsParenthesesValid("[]()}");

    }
  }
}