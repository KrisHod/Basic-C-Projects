using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    internal class Employee: IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("I quit!!!");
        }
    }
}
