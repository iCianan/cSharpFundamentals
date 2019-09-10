using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("KB's Grade Book");
            var log = new Logger();
            log.Log("Welcome to GradeBook Platinum. Press Q when you are done");
            log.Log("Enter your name: ");
            var input = Console.ReadLine();
            book.ChangeName(input);

            while (input != "q")
            {
                log.Log("Enter your grade: ");
                input = Console.ReadLine();
                if (input?.ToLower() == "q" || input == "")
                {
                    break;
                }
                book.AddGrade(Convert.ToDouble(input));
            }
            var stats = book.ComputeStatistics();
            book.ShowStatistics(stats);

        }
    }
}
