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

            LinkedList ll = new LinkedList();
            ll.insert(5);
            Console.WriteLine(ll.Head);
            ll.insert(15);
            ll.insert(24);
            ll.insert(75);
            ll.insert(14);
            ll.insert(37);

            TreesAndGraphs.BinarySearchTree bst = new TreesAndGraphs.BinarySearchTree();
            bst.Insert(5);
            

        }
    }
}