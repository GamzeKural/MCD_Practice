using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Square S1 = new Square(5.2f);
            S1.CalculateArea();

            S1.CalculatePerimeter();

            Console.WriteLine("Square Alan: "+S1.Area+" - "+"Square Çevre: "+S1.Perimeter);


            Rectangle R1 = new Rectangle(3f,5f);
            R1.CalculateArea();
            
            R1.CalculatePerimeter();

            Console.WriteLine("Regtangle Alan: " + R1.Area + " - " + "Regtangle Çevre: " + R1.Perimeter);


            Circle C1 = new Circle(8f);
            C1.CalculateArea();

            C1.CalculatePerimeter();

            Console.WriteLine("Circle Alan: " + C1.Area + " - " + "Circle Çevre: " + C1.Perimeter);

            Console.ReadKey();
        }
    }
}
