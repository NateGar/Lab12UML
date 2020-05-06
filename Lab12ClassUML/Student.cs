using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address} \nProgram: {Program} \nYear: {Year} \nFee: {Fee}";
        }
    }
}
