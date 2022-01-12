using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
            : base("You entered negative number. Please try again") { }
    }

}
