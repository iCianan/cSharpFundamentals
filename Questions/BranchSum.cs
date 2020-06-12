using Core;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class BranchSum
    {

        // O(n) time | O(n) space
        public static List<int> BranchSums(BST root)
        {
            var sums = new List<int>();
            CalculateBranchSums(root, 0, sums);
            return sums;
        }    

        public static List<int> CalculateBranchSums(BST root, int runningSum, List<int> sums)
        {

            if (root == null) return sums;
            var newRunningSum = runningSum + root.value;
            if (root.left == null && root.right == null)
            {
                sums.Add(newRunningSum);
                return sums;
            }
            CalculateBranchSums(root.left, newRunningSum, sums);
            CalculateBranchSums(root.right, newRunningSum, sums);
            return sums;
        }
    }
}
