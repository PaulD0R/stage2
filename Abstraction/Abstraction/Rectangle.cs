using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Rectangle : Shape
    {
        private int _length;
        private int _height;

        public Rectangle(int length, int height) { _height = height; _length = length; }

        public int Length
        {
            get { return _length; }
            set { if (value > 0) _length = value; }
        }

        public override double GetArea()
        {
            return _length * _height;
        }
    }
}
