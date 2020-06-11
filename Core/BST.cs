using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class BST
    {
        public BST left;
        public BST right;
        public int value;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            BST newNode = new BST(value);
            BST current = this;
            while (true)
            {
                if (current.value > value)
                {
                    if (current.left == null)
                    {
                        current.left = newNode;
                        return newNode;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = newNode;
                        return newNode;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }
        }
        public bool Contains(int value)
        {
            if (this.value == value) return true;
            var current = this;
            while (true)
            {
                if (current.value > value)
                {
                    if (current.left == null) return false;
                    else
                    {
                        current = current.left;
                    }
                }
                else if (current.value < value)
                {
                    if (current.right == null) return false;
                    else
                    {
                        current = current.right;
                    }
                }
                else return true;
            }
        }
 
    }
}
