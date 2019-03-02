using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape C1 = new Circle()
            {
                Height  = 10,
                Radious = 10
            };

            C1.PrintParameters();
            Console.WriteLine("The Area of circle {0}", C1.CalculateArea());
            Console.WriteLine("The Volume of cylinder {0}", C1.CalculateVolume());
            Console.WriteLine();

            Shape R1 = new Rectangle()
            {
                Height = 10,
                Width  = 10,
                Length = 10
            };

            R1.PrintParameters();
            Console.WriteLine("The Area of Rectangle {0}", R1.CalculateArea());
            Console.WriteLine("The Volume of Cube {0}", R1.CalculateVolume());
            Console.WriteLine();

            Shape T1 = new Triangle()
            {
                Edge = 10,
                Trinaglebase = 10,
                Trinagleheight = 10
            };

            T1.PrintParameters();
            Console.WriteLine("The Area of Triangle {0}", T1.CalculateArea());
            Console.WriteLine("The Volume of Triangle {0}", T1.CalculateVolume());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
