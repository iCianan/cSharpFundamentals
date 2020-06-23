using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class BreathFirstSearch
    {
        public static List<string> printBFS(Node node, List<string> results)
        {            
            var queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                results.Add(current.Name);
                foreach (var child in current.children)
                {
                    queue.Enqueue(child);
                }
            }
            return results;
        }
    }
}
