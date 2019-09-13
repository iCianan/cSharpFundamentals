using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public interface IBook
    {
    void AddGrade(double grade);
    void ChangeName(string name);
    void ComputeStatistics();
    string Name { get; }
    event GradeAddedDelegate GradeAdded;

  }
}
