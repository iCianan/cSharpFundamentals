using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class FindClosetValueBST
    {
        public static int Find(BST tree, int target)
        {
            if (tree == null) return -1;
            var closest = int.MinValue;
            var current = tree;
            while (current != null)
            {
                if (Math.Abs(target - closest) > Math.Abs(target - current.value)) 
                    closest = current.value;
                if (target < current.value) current = current.left;
                else if (target > current.value) current = current.right;
                else break;
            }
            return closest;
        }
    }
}

