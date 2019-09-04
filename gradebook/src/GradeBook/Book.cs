using System;
using System.Collections.Generic;


namespace GradeBook
{
    public class Book
    {
        private List<double> _grades { get; set; }
        private string _name { get; set; }
        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;
        }
        public void AddGrade(double grade)
        {
            _grades.Add(grade);
        }
        public Dictionary<string, double> ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var average = 0.0;
            var results = new Dictionary<string, double>();        

            foreach (var number in _grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                average += number;
            }

            average /= _grades.Count;
            results.Add("High Grade", highGrade);
            results.Add("Low Grade", lowGrade);
            results.Add("Average", average);
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {results:N1}");
            return results;
        }

    }
}
