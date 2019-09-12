using System;
using System.Collections.Generic;


namespace GradeBook
{
  public delegate void GradeAddedDelegate(object sender, EventArgs args);
  public class Book : NamedObject
  {
    public List<double> Grades { get; private set; }
    public const string CATEGORY = "science";
    public Book(string name) : base(name)
    {
      Grades = new List<double>();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      if (grade <= 100 && grade >= 0)
      {
        Grades.Add(grade);
        if (GradeAdded != null)
        {
          GradeAdded(this, new EventArgs());
        }
      }
      else
      {
        throw new ArgumentException($"Invalid {nameof(grade)}");
      }

    }
    public event GradeAddedDelegate GradeAdded;

    public void ChangeName(string name)
    {
      Name = name;
    }
    public void ShowStatistics(Statistics stats)
    {
      Console.WriteLine($"The lowest grade is {stats.Low}");
      Console.WriteLine($"The highest grade is {stats.High}");
      Console.WriteLine($"The average grade is {stats.Average:N1}");
      Console.WriteLine($"The letter grade is {stats.letter}");

    }
    public Statistics ComputeStatistics()
    {
      var stats = new Statistics();
      ComputeNumberGrade(stats); 
      ComputeLetterGrade(stats);
      return stats;
    }
    public void ComputeNumberGrade(Statistics stats)
    {
      foreach (var grade in Grades)
      {
        stats.Low = Math.Min(grade, stats.Low);
        stats.High = Math.Max(grade, stats.High);
        stats.Average += grade;
      }
      stats.Average /= Grades.Count;

    }
    public void ComputeLetterGrade(Statistics stats)
    {
      switch (stats.Average)
      {
        case var d when d >= 90.0:
          stats.letter = 'A';
          break;
        case var d when d >= 80.0:
          stats.letter = 'B';
          break;
        case var d when d >= 70.0:
          stats.letter = 'C';
          break;
        case var d when d >= 60.0:
          stats.letter = 'D';
          break;

        default:
          stats.letter = 'F';
          break;
      }
    }

  }
}
