using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
