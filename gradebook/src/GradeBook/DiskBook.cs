using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
  public class DiskBook : Book
  {
 
    public const string CATEGORY = "science";

    public override event GradeAddedDelegate GradeAdded;

    public DiskBook(string name): base(name)
    {
      
    }

    public override void ChangeName(string name)
    {
      Name = name;
    }

    public override void AddGrade(double grade)
    {
      string path = $"{Name}.txt";
            
      using (var writer = File.AppendText(path))
      {
        writer.WriteLine(grade);
      }
    }

    public override void ComputeStatistics()
    {
      var stats = new Statistics();
      var grades = new List<Double>();
      string path = $"{Name}.txt";

      foreach (var line in File.ReadAllLines(path))
      {
        grades.Add(Convert.ToDouble(line));
      }
      stats.ComputeGrades(grades);    


    }


  }
}