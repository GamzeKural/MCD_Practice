using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Practice
{
    public class Square : Shape
    {
        private float _side;

        public float Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public Square(float side)
        {
            _side = side;
            
        }

        public override void CalculateArea()
        {
            Area = _side * _side;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 4 * _side;
        }
    }
}
