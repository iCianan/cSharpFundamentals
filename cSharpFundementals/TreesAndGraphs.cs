using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpFundementals
{
    public class TreesAndGraphs
    {
        public class BinarySearchTree
        {
            public Node Root { get; set; }
            public BinarySearchTree()
            {
                Root = null;
            }
            public Node Insert(int data)
            {
                Node newNode = new Node(data);
                if (Root == null)
                {
                    Root = newNode;
                    return Root;
                }
                return Root;
            }

        }
        public class Graph
        {

        }
        public class Node
        {
            public int Data { get; set; }
            public Node[] Children { get; set; }
            public Node(int data)
            {
                Data = data;
                Children = Array.Empty<Node>();
            }
        }
    }
}
