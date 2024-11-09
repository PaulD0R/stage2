using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Car : Vehicle 
    {
        private int _fuelConsumption;

        public Car(string brand, int maxSpeed, int fuelConsumption) 
            : base(brand, maxSpeed)
        {
            _fuelConsumption = fuelConsumption;
        }

        public int FuelConsumption
        {
            get { return _fuelConsumption; }
            set { if (value > 0) _fuelConsumption = value; }
        }
    }
}
