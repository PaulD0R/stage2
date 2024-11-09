using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Gav";
        }
    }
}
