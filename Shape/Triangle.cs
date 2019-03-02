using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : Shape
    {
        public double Trinaglebase   { get; set; }
        public double Trinagleheight { get; set; }
        public double Edge           { get; set; }

        public override double CalculateArea()
        {
            Area = Math.Round((0.5 * Trinaglebase * Trinagleheight),3);
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume = Math.Round(((1.0/3.0) * Edge * Edge * Trinagleheight), 3);
            return Volume;
        }

        public override void PrintParameters()
        {
            Console.WriteLine("Base:    {0}", Trinaglebase);
            Console.WriteLine("Height:  {0}", Trinagleheight);
            Console.WriteLine("Edge:    {0}", Edge);
        }

    }
}
