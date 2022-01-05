using System;

//Create an enum for the days of the week.
//Prompt the user to enter the current day of the week.
//Assign the value to a variable of that enum data type you just created.
//Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

namespace Enums_Assignment
{
    internal class Program
    {
        static void Main()
        {
            try{ 
            Console.WriteLine("enter the current day of the week");
            WeekDays day = (WeekDays) Enum.Parse(typeof(WeekDays), Console.ReadLine(), true);
            Console.WriteLine(day);
            }
            catch (Exception ex){
            Console.WriteLine("Please enter an actual day of the week.");
            }
            finally{ 
            Console.ReadLine();
            }
        }
    }
}
