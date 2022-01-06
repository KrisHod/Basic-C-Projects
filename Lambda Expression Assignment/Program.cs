using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Boris", LastName = "Lopata", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Natasha", LastName = "Kuznecova", Id = 2 };
            Employee employee3 = new Employee() { FirstName = "Joe", LastName = "Shmugal", Id = 3 };
            Employee employee4 = new Employee() { FirstName = "Venya", LastName = "Kozur", Id = 4 };
            Employee employee5 = new Employee() { FirstName = "Alex", LastName = "Kutepov", Id = 5 };
            Employee employee6 = new Employee() { FirstName = "Joe", LastName = "Korovkin", Id = 6 };
            Employee employee7 = new Employee() { FirstName = "Denis", LastName = "Shumko", Id = 7 };
            Employee employee8 = new Employee() { FirstName = "Vladimir", LastName = "Tkach", Id = 8 };
            Employee employee9 = new Employee() { FirstName = "Joe", LastName = "Kogot", Id = 9 };
            Employee employee10 = new Employee() { FirstName = "Ludmila", LastName = "Vahta", Id = 10 };

            List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.FirstName);
            }

            List<Employee> newList2 = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> newList3 = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("*****************");
            foreach (Employee employee in newList2)
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.WriteLine("*****************");
            foreach (Employee employee in newList3)
            {
                Console.WriteLine(employee.Id);
            }
            Console.ReadLine();
        }
    }
}
