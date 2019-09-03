using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {           
            var book = new Book("KB's Grade Book");
            var numbers = new[] { 3.32, .21, 5.45, 13.9, 393.7621 };
            List<double> grades = new List<double>() { 32.324, 43.432, 9.2313, 0.9310, 20.1 };
            foreach (var number in grades)
            {
                book.AddGrade(number);
            }
            foreach (var number in numbers)
            {
                book.AddGrade(number);
            }
            book.ShowStatistics();

        }
    }
}
