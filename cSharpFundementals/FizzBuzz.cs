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
                if (item % 5 == 0 && item % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                if (item % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                if (item % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
            }

        }
    }
}
