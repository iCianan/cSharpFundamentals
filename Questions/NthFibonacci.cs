using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class NthFibonacci
    {
        public static int GetNthFib(int n)
        {
            if (n == 2)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 0;
            }
            else
            {
                return GetNthFib(n - 1) + GetNthFib(n - 2);
            }
        }
    }
}
