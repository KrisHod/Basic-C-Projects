using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    internal class OverloadedMethods
    {
        public int addition (int a){
        return a + 2;
        }
        public int addition(decimal a)
        {
            return Convert.ToInt32(a) + 3;
        }
        public int addition(string a)
        {
            return Convert.ToInt32(a) + 4;
        }
    }
}
