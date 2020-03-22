// Feel free to add new properties and methods to the class.



namespace Core
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;
        public DoublyLinkedList()
        {
            Head = new Node(1);
            Head.Next = new Node(2);
            Head.Next.Next = new Node(3);
            Head.Next.Next.Next = new Node(4);
            Head.Next.Next.Next.Next = new Node(5);
            Tail = Head.Next.Next.Next.Next;
      
        }

        public void SetHead(Node node)
        {
            if (Head == null)
            {
                SetTail(node);
            }
            InsertBefore(Head, node);
        }

        public void SetTail(Node node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            InsertAfter(Tail, node);
        }

        public void InsertBefore(Node node, Node nodeToInsert)
        {
            if (Head == null)
            {
                SetHead(nodeToInsert);
            }
            Node current = Head;
            while (current != null)
            {
                if (current.Value == node.Value)
                {
                    nodeToInsert.Next = current;
                    nodeToInsert.Prev = current.Prev;
                    current.Prev.Next = nodeToInsert;
                    current.Prev = nodeToInsert;
                }
                current = current.Next;
            }
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            if (Head == null)
            {
                SetHead(nodeToInsert);
            }
            if (node == Tail)
            {
                Tail.Next = nodeToInsert;
                nodeToInsert.Prev = Tail;
                Tail = nodeToInsert;
            }
            Node current = Head;
            while (current != null)
            {
                if (current.Value == node.Value)
                {
                    nodeToInsert.Next = current.Next;
                    nodeToInsert.Prev = current;
                    current.Next.Prev = nodeToInsert;
                    current.Next = nodeToInsert;
                }
                current = current.Next;

            }
        }

        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            if (Head == null)
            {
                SetHead(nodeToInsert);
            }
            Node current = Head;
            int count = 1;
            while (current != null)
            {
                if (count == position)
                {
                    InsertBefore(current, nodeToInsert);
                }
                current = current.Next;
                count++;
            }
        }

        public void RemoveNodesWithValue(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                    current.Next = null;
                    current.Prev = null;
                }
                current = current.Next;
            }
        }

        public void Remove(Node node)
        {
            RemoveNodesWithValue(node.Value);
        }

        public bool ContainsNodeWithValue(int value)
        {
            if (Head == null) return false;
            Node current = Head;
            while (current != null)
            {
                if (current.Value == value) return true;
                current = current.Next;
            }
            return false;
        }
    }

    // Do not edit the class below.
    public class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int value)
        {
            this.Value = value;
        }
    }


}
