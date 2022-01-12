using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string courseName = "C# and .NET Framework";

            var student1 = new Student("Sasha", 78);
            var student2 = new Student("Kostya");

            Console.WriteLine(student1.Name + " and " + student2.Name + " are students of " + courseName + " course");
            Console.Read();

        }
    }
}
