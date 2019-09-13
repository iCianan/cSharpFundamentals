using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      //IBook book = new InMemoryBook("KB's Grade Book");
      IBook book = new DiskBook("Larry's Grade Book");


      var log = new Logger();
      log.Log("Welcome to GradeBook Platinum. Press Q when you are done");
      log.Log("Enter your name: ");
      var name = Console.ReadLine();
      book.ChangeName(name);
      EnterGrades(book, log);
      book.ComputeStatistics();
    }

    private static void EnterGrades(IBook book, Logger log)
    {
      while (true)
      {
        log.Log("Enter your grade: ");
        var input = Console.ReadLine();
        if (input.ToLower() == "q" || input == "")
        {
          break;
        }
        try
        {
          var grade = Convert.ToDouble(input);
          book.AddGrade(grade);
        
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
    }

    static void EventThing(object o, EventArgs e)
    {
      Console.WriteLine("a grade was added");
    }
  }
}
