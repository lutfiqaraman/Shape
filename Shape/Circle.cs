using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle : Shape
    {        
        public double Radious { get; set; }
        public double Height  { get; set; }

        public override double CalculateArea()
        {
            Area = Math.Round((Math.PI * (Radious * Radious)), 3);
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume = Math.Round((Math.PI * Radious * Radious * Height), 3);
            return Volume;
        }

        public override void PrintParameters()
        {
            Console.WriteLine("Radious: {0}", Radious);
            Console.WriteLine("Height:  {0}", Height);
        }
    }
}
