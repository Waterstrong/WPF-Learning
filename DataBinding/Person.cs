using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DataBinding
{
    class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                Notify("Name");
            }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set 
            { 
                _age = value;
                Notify("Age");
            }
        }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
