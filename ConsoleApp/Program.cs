using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Boris", "Katia", "Ivan", "Eva", "Afonia", "Boris"};
            List<string> newList = new List<string>();

            foreach(string name in names){
   
                if (newList.Contains(name))
                {
                    Console.WriteLine(name + " has already appeared in the list");
                }
                else{
                    Console.WriteLine(name);
                    newList.Add(name);
                }     
            }
            Console.Read();
          
        }
    }
}
