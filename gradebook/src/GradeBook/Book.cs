using System;
using System.Collections.Generic;


namespace GradeBook
{
    public class Book
    {
        public List<double> Grades { get; private set; }
        public string Name { get; private set; }
        public Book(string name)
        {
            Grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
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
            foreach (var grade in Grades)
            {
                stats.Low = Math.Min(grade, stats.Low);
                stats.High = Math.Max(grade, stats.High);
                stats.Average += grade;
            }
            stats.Average /= Grades.Count;
            return stats;
        }

    }
}
