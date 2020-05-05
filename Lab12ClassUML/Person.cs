using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }


        public virtual string ToString()
        {
            return ($"{Name} + {Address}");
        }
    }
}
