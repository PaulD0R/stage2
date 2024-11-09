using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Vehicle
    {
        protected string _brand;
        protected int _maxSpeed;

        public Vehicle(string brand, int maxSpeed) { _brand = brand; _maxSpeed = maxSpeed; }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int MaxSpeed 
        {
            get { return _maxSpeed; }
            set { if (value > 0) _maxSpeed = value; }
        }
    }
}
