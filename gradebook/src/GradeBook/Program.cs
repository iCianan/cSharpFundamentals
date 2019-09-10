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

            while (true)
            {
                log.Log("Enter your grade: ");
                input = Console.ReadLine();
                if (input.ToLower() == "q" || input == "")
                {
                    break;
                }
                try
                {
                    book.AddGrade(double.Parse(input));

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            var stats = book.ComputeStatistics();
            book.ShowStatistics(stats);

        }
    }
}
