using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class RightTriangle : IPolygon
    {
        private double side1;
        private double side2;
        private double hypotenuse;

        public RightTriangle(double side1, double side2, double hypotenuse )
        {
            this.side1 = side1;
            this.side2 = side2;
            this.hypotenuse = hypotenuse;

            if ( side1 * side1 + side2 * side2 != hypotenuse * hypotenuse )
            {
                throw new ArgumentException("A^2 + B^2 must equal C^2");
            }
        }
        public double GetArea()
        {
            return side1 * side2 * .5;
        }

        public double GetPerimeter()
        {
            return side1 + side2 + hypotenuse;
        }

        public int NumberOfSides()
        {
            return 3;
        }
    }
}
