﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }


        public virtual string ToString()
        {
            return ($"Name: {Name} \nAddress: {Address}");
        }
    }
}
