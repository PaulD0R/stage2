using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Bicycle : Vehicle
    {
        private string _type;
        public Bicycle(string brand, int maxSpeed, string type) 
            : base(brand, maxSpeed) 
        {
            _type = type;
        } 

        public string Type 
        { 
            get { return _type; }
            set { _type = value; }
        }
    }
}
