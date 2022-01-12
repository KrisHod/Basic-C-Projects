using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    public class Student
    {
        public Student(string name, int avgGrade)
        {
            Name = name;
            AvgGrade = avgGrade;
        }

        public Student(string name) : this(name, 0)
        {

        }
        public string Name { get; set; }
        public int AvgGrade { get; set; }
    }
}
