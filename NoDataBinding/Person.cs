using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoDataBinding
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
