using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Animal
    {
        protected string _name;
        protected int _age;

        public Animal(string name, int age) { _age = age; _name = name; }

        public string Name 
        { 
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { if (value > 0 && value < 30) _age = value; }
        }

        public virtual string MakeSound()
        {
            return "Sound";
        }
    }
}
