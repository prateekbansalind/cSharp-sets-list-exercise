using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add students to a class roaster until there are no more students.
            //Then print out the count of the students to the console.
            List<string> firstNames = new List<string>();
            string firstName = "";
            string decisionVar = "";

            do
            {
                Console.Write("Enter you name (student first name): ");
                firstName = Console.ReadLine();

                firstNames.Add(firstName);

                Console.Write("Do you want to make another entry (y/n): ");
                decisionVar = Console.ReadLine(); 

            } while (decisionVar.ToLower() == "y");

            Console.WriteLine($"The number of student already saved in the database are {firstNames.Count}");


            Console.ReadLine();
        }
    }
}