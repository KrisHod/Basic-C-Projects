using System;


namespace Daily_Report_Project
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");

            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool isHelpNeeded = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.Read();
        }
    }
}
