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
        public void ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var results = 0.0;

            foreach (var number in _grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                results += number;
            }
            results /= _grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {results:N1}");
        }

    }
}
