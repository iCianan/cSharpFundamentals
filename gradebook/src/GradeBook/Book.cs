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
        public void ShowStatistics(Statistics stats)
        {
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
        public Statistics ComputeStatistics()
        {
            var stats = new Statistics();                 
            foreach (var grade in _grades)
            {
                stats.Low = Math.Min(grade, stats.Low);
                stats.High = Math.Max(grade, stats.High);
                stats.Average += grade;
            }
            stats.Average /= _grades.Count;
            return stats;
        }

    }
}
