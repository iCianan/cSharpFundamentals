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
        public static List<int> BranchSums(BST root)
        {
            if (root == null ) return new List<int>() { 0 };
            if (root.left == null && root.right == null)
            {
                return new List<int>() { root.value };
            }
            List<int> leftBranchSum = BranchSums(root.left);
            List<int> rightBranchSum = BranchSums(root.right);
            List<int> results = new List<int>(leftBranchSum);
            foreach (var item in rightBranchSum)
            {
                results.Add(item);
            }
            for (int i = 0; i < results.Count(); i++)
            {
                results[i] += root.value;
            }
            return results;

        }
    }
}
