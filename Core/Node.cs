using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Node
    {
        public string Name;
        public List<Node> children = new List<Node>();
        public Node(string name)
        {
            this.Name = name;
        }

        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }
    }
}
