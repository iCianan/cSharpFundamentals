using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Core
{
    public class Graph
    {

        public Dictionary<string, List<string>> adjacencyList { get; set; }

        public Graph()
        {
            adjacencyList = new Dictionary<string, List<string>>();
        }

        public void AddVertex(string key)
        {
            if (!adjacencyList.ContainsKey(key))
            {
                adjacencyList[key] = new List<string>();
            }
        }
        public void AddEdge(string v1, string v2)
        {
            if (adjacencyList.ContainsKey(v1) && adjacencyList.ContainsKey(v2))
            {
                adjacencyList[v1].Add(v2);
                adjacencyList[v2].Add(v1);
            }

        }
        public void RemoveEdge(string v1, string v2)
        {
            if (adjacencyList.ContainsKey(v1) && adjacencyList.ContainsKey(v2))
            {
                adjacencyList[v1].Remove(v2);
                adjacencyList[v2].Remove(v1);
            }
        }
        public void RemoveVertex(string vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                foreach (var edge in adjacencyList[vertex])
                {
                    adjacencyList[edge].Remove(vertex);
                }
            }
            adjacencyList.Remove(vertex);
        }
        public List<string> DepthFirstRecursive(string start)
        {
            List<string> results = new List<string>();
            Dictionary<string, bool> visted = new Dictionary<string, bool>();
            void SearchNeighbors(string v) {
                if (v == null) throw new Exception("Bad string");
                visted[v] = true;
                results.Add(v);
                foreach (string neighbor in adjacencyList[v]) {
                    if (!visted.ContainsKey(neighbor))
                    {
                        SearchNeighbors(neighbor);
                    }
                }
            }
            SearchNeighbors(start);
            return results;           
        
        }
        public List<string> DepthFirstIterative(string start)
        {
            Stack<string> stack = new Stack<string>();
            List<string> results = new List<string>();
            Dictionary<string, bool> visted = new Dictionary<string, bool>(); 
            stack.Push(start);
            visted[start] = true;
            while (stack.Count > 0)
            {
                string temp = stack.Pop();
                results.Add(temp);
                foreach (string neighbor in adjacencyList[temp]) {
                    if (!visted.ContainsKey(neighbor))
                    {
                        visted[neighbor] = true;
                        stack.Push(neighbor);
                    }
                }
            }
            return results;
        }
    }
}
