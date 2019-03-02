using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        protected double Area;
        protected double Volume;

        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        public abstract void   PrintParameters();
    }
}
