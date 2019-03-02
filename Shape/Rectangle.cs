using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Shape
    {
        public double Width  { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        public override double CalculateArea()
        {
            Area = Math.Round((Height * Width), 3);
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume = Math.Round(( Width * Height * Length), 3);
            return Volume;
        }

        public override void PrintParameters()
        {
            Console.WriteLine("Width:   {0}", Width);
            Console.WriteLine("Height:  {0}", Height);
            Console.WriteLine("Length:  {0}", Length);
        }
    }
}
