using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Core
{
    class Program
    {
        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            string[] states = {
            "Alaska",
            "Alabama",
            "Arkansas",
            "American Samoa",
            "Arizona",
            "California",
            "Colorado",
            "Connecticut",
            "District of Columbia",
            "Delaware",
            "Florida",
            "Georgia",
            "Guam",
            "Hawaii",
            "Iowa",
            "Idaho",
            "Illinois",
            "Indiana",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Massachusetts",
            "Maryland",
            "Maine",
            "Michigan",
            "Minnesota",
            "Missouri",
            "Mississippi",
            "Montana",
            "North Carolina",
            "North Dakota",
            "Nebraska",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "Nevada",
            "New York",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Puerto Rico",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Virginia",
            "Virgin Islands",
            "Vermont",
            "Washington",
            "Wisconsin",
            "West Virginia",
            "Wyoming"
                    };

            //        Graph graph = new Graph();

            //        foreach (string state in states)
            //        {
            //            graph.AddVertex(state);
            //        }

            //        graph.AddEdge("Alaska", "California");
            //        graph.AddEdge("California", "Kansas");
            //        graph.AddEdge("Kansas", "Michigan");
            //        graph.AddEdge("Kansas", "Texas");
            //        graph.AddEdge("Texas", "Florida");
            //        graph.AddEdge("Michigan", "California");
            //        graph.AddEdge("Michigan", "Florida");
            //        graph.AddEdge("Michigan", "Pennsylvania");
            //        graph.AddEdge("Pennsylvania", "North Carolina");
            //        graph.AddEdge("North Carolina", "Florida");

            //        foreach (var item in graph.adjacencyList["Michigan"])
            //        {
            //            Console.WriteLine(item);
            //        }
            //        graph.RemoveVertex("Kansas");
            //        foreach (var item in graph.adjacencyList["Michigan"])
            //        {
            //            Console.WriteLine(item);
            //        }
            //        List<string> results = graph.DepthFirstRecursive("Michigan");
            //        List<string> resultsb = graph.BreathFirstSearch("Michigan");

            //        foreach (var item in results)
            //        {
            //            Console.WriteLine(item);
            //        }

            //        foreach (var item in resultsb)
            //        {
            //            Console.WriteLine(item);
            //        }

            //int[] nums = new int[] { 12,41,56,2,58,74,32,22,10,95};

            //int[] sorted = MergeSort.Sort(nums);
            //int[] sorted2 = InsertionSort.Sort(nums);
            //Console.WriteLine(sorted);
            //Console.WriteLine(sorted2);

            //DoublyLinkedList list = new DoublyLinkedList();
            //Node node = new Node(4);
            //list.SetHead(node);


            //Arrays arrays = new Arrays();
            //arrays.ListNumbersBackwards();
            //arrays.ReadFromConsole();
            foreach (var item in states)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Stack<string> stack = new Stack<string>();
            foreach (var item in states)
            {
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }
            
        }
    }
}