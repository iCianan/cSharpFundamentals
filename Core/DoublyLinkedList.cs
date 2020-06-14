

using System;
using System.Reflection.Metadata.Ecma335;

namespace Core
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Count;
        public DoublyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;      
        }

       public void Add(T node)
        {
            Node<T> newNode = new Node<T>(node);

            if (Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;               
            }
            else
            {
                this.Tail.Next = newNode;
                newNode.Prev = this.Tail;
                this.Tail = newNode;
            }
            this.Count++;
        }
        public T RemoveAt(int index)
        {
            if (index > Count || index  < 0)
            {
                throw new IndexOutOfRangeException("Get it together");
            }

            Node<T> current = Head;
            while (current != null && index != 0)
            {
                index--;
                current = current.Next;
            }
            RemoveNode(current);

            return current.Value;           
        }

        private void RemoveNode(Node<T> node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            node.Next = null;
            node.Prev = null;
        }


        public void SetHead(T node)
        {
   
        }

        public void SetTail(T node)
        {

        }

        public void InsertBefore(T node, T nodeToInsert)
        {

        }

        public void InsertAfter(T node, T nodeToInsert)
        {

        }

        public void Get(int position, T nodeToInsert)
        {

        }

        public void RemoveNodesWithValue(int value)
        {

        }


        public void PrintReversedLinkedList(Node<T> head)
        {
            if (head == null)
            {
                return;
            }
            PrintReversedLinkedList(head.Next);
            Console.WriteLine(head.Value);
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }        
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }


}
