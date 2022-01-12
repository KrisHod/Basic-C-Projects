using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    public class ZeroNumberException: Exception
    {
        public ZeroNumberException()
            : base("You entered ZERO. Please try again") { }
    }
}
