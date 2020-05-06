using System;

namespace Lab12ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Person steve = new Person("steve", "123 1st st.");
            Console.WriteLine(steve.ToString());
            Console.WriteLine();

            Student jim = new Student("Jim", "123 2nd st", "Pre Med", 2025, 100000.00);
            Console.WriteLine(jim.ToString());
            Console.WriteLine();

            Staff mike = new Staff("Mike", "123 3rd st", "Grand Circus", 2.50);
            Console.WriteLine(mike.ToString());
        }
    }
}
