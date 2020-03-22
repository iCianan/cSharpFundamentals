using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class FizzBuzz
    {
        public void fizzBuzz(int[] arr)
        {
            foreach (var item in arr)
            {
                bool newLine = item % 3 == 0;
                if (newLine) Console.Write("Fizz");
                newLine = item % 5 == 0;
                if (newLine) Console.Write("Buzz");
                Console.Write(Environment.NewLine);
            }

        }
    }
}
