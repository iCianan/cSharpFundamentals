using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Queue
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public int Size { get; private set; }
        public Queue()
        {
            First = null;
            Last = null;
            Size = 0;
        }

        public int Enqueue(int val)
        {
            Node newNode = new Node(val);
            if (First == null)
            {
                First = newNode;
                Last = newNode;
                Size++;
                return Size;
            }            
            Last.Next = newNode;
            Last = newNode;
            Size++;
            return Size;
            
        }

        public Node Dequeue()
        {
            if (First == null)
            {
                throw new Exception("Nothing in queue");
            }
            Node current = First;
            First = current.Next;
            if (First == null)
            {
                Last = First;
                Size--;
                return current;
                
            }
            Size--;
            return current;
        }

        public class Node
        {
            public int Val { get; private set; }
            public Node Next { get; set; }
            public Node(int val)
            {
                Val = val;
                Next = null;
            }
        }
    }
}
