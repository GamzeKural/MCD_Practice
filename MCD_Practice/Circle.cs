using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Practice
{
    public class Circle : Shape
    {
        float pi = 3.14f;
        private float _radius;

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(float radius)
        {
            _radius = radius;
            
        }

        public override void CalculateArea()
        {
            Area = pi * _radius * _radius;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 2 * pi * _radius;
        }
    }
}
