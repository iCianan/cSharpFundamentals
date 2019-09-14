using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpFundementals
{
    public class FizzBuzz
    {
        public void fizzBuzz(int[] arr)
        {
            foreach (var item in arr)
            {
                bool newLine = false;
                if (item % 3 == 0) 
                {
                    Console.Write("Fizz");
                    newLine = true;
                }
                if (item % 5 == 0)
                {
                    Console.Write("Buzz");
                    newLine = true;
                }
                if (newLine)
                {
                    Console.Write(Environment.NewLine);
                }
            }

        }
    }
}
