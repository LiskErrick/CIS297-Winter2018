using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Square : IPolygon
    {
        public static int NUMBER_OF_SIDES = 4;

        private double sideLength;

        public Square(double sideLength )
        {
            this.sideLength = sideLength;
        }

        public double GetArea()
        {
            return sideLength * sideLength;
        }

        public double GetPerimeter()
        {
            return sideLength * 4;
        }

        public int NumberOfSides()
        {
            return NUMBER_OF_SIDES;
        }
    }
}
