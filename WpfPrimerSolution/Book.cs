using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfPrimerSolution
{
    class Book
    {
        public Book(){}
        public string Name { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            string str = Name + " 售价为：" + Price + "元";
            return str;
        }
    }
}
