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
        public Statistics()
        {
            Average = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;

        }
    }
}
