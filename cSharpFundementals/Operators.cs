using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpFundementals
{
    class Operators
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int A { get; private set; }
        public Operators(string firstName, string lastName, int? a)
        {
            A = a == null ? 8 : 5;
            FirstName = firstName;
            LastName = lastName;
        }   

    }
}
