using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class RemoveKthNodeFromEnd
    { 
        public static void Remove(DoublyLinkedList<int> list, int k)
        {
			if (list.Head == null) return;
			var current = list.Head;
			int count = 1;
			while (current.Next != null)
			{
				current = current.Next;
				count++;
			}
			current = list.Head;
			int index = count - k;
			while (current != null)
			{
                if (index == 0)
                {
					list.Head = current.Next;
					current.Next = null;
					list.Count--;
					return;
                }
				if (index == 1)
				{
					current.Next = current.Next.Next;
					list.Count--;
					return;
				}
				current = current.Next;
				index--;
			}
		}
    }
}
