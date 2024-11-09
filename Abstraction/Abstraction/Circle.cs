using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Circle : Shape
    {
        private int _radius;
        
        public Circle(int radius) { _radius = radius; }

        public int Radius
        {
            get { return _radius; }
            set { if (value > 0) _radius = value; }
        }

        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
