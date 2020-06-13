using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Questions
{
    public static class NodeDepth
    {
        public static int NodeDepthSum(BST root)
        {
            int sum = 0;
            var level = new
            {
                Node = root,
                Depth = 0
            };
            var stack = new Stack<Level>();
            stack.Push(new Level(root, 0));
            while (stack.Count > 0)
            {
                var nodeInfo = stack.Pop();
                var node = nodeInfo.node;
                var depth = nodeInfo.depth;
                if (node == null)
                {
                    continue;
                }
                sum += depth;
                stack.Push(new Level(node.left, depth + 1));
                stack.Push(new Level(node.right, depth + 1));
            }
            return sum;
        }
    }

    public class Level
    {
        public BST node;
        public int depth;

        public Level(BST node, int depth)
        {
            this.node = node;
            this.depth = depth;
        }
    }
}
