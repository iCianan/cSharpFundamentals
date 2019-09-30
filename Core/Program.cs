using System;
using System.Collections.Generic;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays arrays = new Arrays();
            //arrays.ListDaysInOrder();
            ////arrays.ReplaceAllDaysWithMonths();
            //Queue queue = new Queue();
            //int[] numbers =
            //{
            //    1,5,7,11,15,17,24,26,28,32,36,39,40,45,52,53,58,59,63,64,69,72,77,78,98,99
            //};.
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
            //foreach (var num in numbers)
            //{
            //    queue.Enqueue(num);
            //}
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(queue.Dequeue());                
            //}
            Graph graph = new Graph();

            foreach (string state in states)
            {
                graph.AddVertex(state);
            }

            graph.AddEdge("Alaska", "California");
            graph.AddEdge("California", "Kansas");
            graph.AddEdge("Kansas", "Michigan");
            graph.AddEdge("Kansas", "Texas");
            graph.AddEdge("Texas", "Florida");
            graph.AddEdge("Michigan", "California");
            graph.AddEdge("Michigan", "Florida");
            graph.AddEdge("Michigan", "Pennsylvania");
            graph.AddEdge("Pennsylvania", "North Carolina");
            graph.AddEdge("North Carolina", "Florida");

            //foreach (var item in graph.adjacencyList["Michigan"])
            //{
            //    Console.WriteLine(item);
            //}
            //graph.RemoveVertex("Kansas");
            //foreach (var item in graph.adjacencyList["Michigan"])
            //{
            //    Console.WriteLine(item);
            //}
            List<string> results = graph.DepthFirstRecursive("Michigan");
            List<string> resultsb = graph.BreathFirstSearch("Michigan");

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            foreach (var item in resultsb)
            {
                Console.WriteLine(item);
            }


        }
    }
}