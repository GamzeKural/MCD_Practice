using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Practice
{
    public class Rectangle : Shape
    {

        private float _height;

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private float _width;

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(float height,float width)
        {
            _height = height;
            _width = width;
            
        }



        public override void CalculateArea()
        {
            Area = _height * _width;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = (_height * 2) + (_width * 2);
        }
    }
}
