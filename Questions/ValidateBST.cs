using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class ValidateBST
    {
        public static bool Validate(BST root)
        {
            if (root == null) return false;
            var current = root;
            while (true)
            {
                if (current.left.value < current.right.value)
                {
                    current = current.left;
                }
                else if (current.right.value > current.left.value)
                {
                    current = current.left;
                }
                else return false;
            }            
        }
        public static bool ValidateInOrder(BST root)
        {
            if (root == null) return false;
            if (root.right == null & root.left == null) return true;
            var isLeftValid = ValidateInOrder(root.left);
            var isRightValid = root.right == null && ValidateInOrder(root.right) == false ?  true: ValidateInOrder(root.right);
            var rootVal = root.value;
            if (isLeftValid == true && isRightValid == true && rootVal > root.left.value && rootVal <= root.right.value)
            {
                return true;
            }
            return false;
            
            

        }
    }
}
