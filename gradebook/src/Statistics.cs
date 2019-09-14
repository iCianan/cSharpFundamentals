using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

  public class Statistics
  {
    public double Average;
    public double High;
    public double Low;
    public char Letter
    {
      get
      {
        switch (Average)
        {
          case var d when d >= 90.0:
            return 'A';

          case var d when d >= 80.0:
            return 'B';

          case var d when d >= 70.0:
            return 'C';

          case var d when d >= 60.0:
            return 'D';

          default:
            return 'F';
        }
      }
    }

    public Statistics()
    {
      Average = 0.0;
      High = double.MinValue;
      Low = double.MaxValue;

    }
    public void ComputeGrades(List<double> grades)
    {
      foreach (var grade in grades)
      {
        Low = Math.Min(grade, Low);
        High = Math.Max(grade, High);
        Average += grade;
      }
      Average /= grades.Count;
      ShowStatistics();
    }

    public void ShowStatistics()
    {
      Console.WriteLine($"The lowest grade is {Low}");
      Console.WriteLine($"The highest grade is {High}");
      Console.WriteLine($"The average grade is {Average:N1}");
      Console.WriteLine($"The letter grade is {Letter}");
    }

  }
}
