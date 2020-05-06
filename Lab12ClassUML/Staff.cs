using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff(string name, string address, string school,double pay): base(name,address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address} \nSchool: {School} \nPay: {Pay}";
        }
    }
}
