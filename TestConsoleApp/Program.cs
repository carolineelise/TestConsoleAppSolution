using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("To The C# World...");
            Console.WriteLine("I am so excited to be in C#. Just wow.");

             int NumberOfStudents = 17;
                var TotalInClass = NumberOfStudents + 2;
            Console.WriteLine($"Number of Students is {NumberOfStudents}, Total Number Of Humans is {TotalInClass} billion");
            var MyName = "Caroline";
            Console.WriteLine($"{MyName} is one of the {NumberOfStudents} learners in the class");
            int Teachers = TotalInClass - NumberOfStudents;
            Console.WriteLine($"That means we have {Teachers} who are not learning");
            Console.WriteLine($"to reiterate we have {TotalInClass - NumberOfStudents} leading the course");
            Console.WriteLine($"wow i love snippets signed, {MyName}");
                var CostofBootcamp = 15500d;
                var daysofBootcamp = 65;
            var Priceperday = CostofBootcamp / daysofBootcamp;
                Console.WriteLine(  $"Each day of bootcamp costs {Priceperday} wow");
        }
    }
}
