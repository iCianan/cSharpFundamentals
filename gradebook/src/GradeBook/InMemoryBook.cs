using System;
using System.Collections.Generic;


namespace GradeBook
{
  public delegate void GradeAddedDelegate(object sender, EventArgs args);
  public class InMemoryBook : Book
  {
    public List<double> Grades { get; private set; }
    public const string CATEGORY = "science";
    public InMemoryBook(string name) : base(name)
    {
     // Grades = new List<double>();
      Name = name;
    }

    public override void AddGrade(double grade)
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
    public override event GradeAddedDelegate GradeAdded;

    public override void ChangeName(string name)
    {
      Name = name;
    }

    public override void ComputeStatistics()
    {
      var stats = new Statistics();
      stats.ComputeGrades(Grades);   
    }

  }
}
