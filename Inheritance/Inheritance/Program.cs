using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle triangle = new RightTriangle(3, 4, 5);
            Square square = new Square(5);

            IPolygon[] shapes = new IPolygon[] { triangle, square };

            foreach( IPolygon myShape in shapes )
            {
                Console.WriteLine($"{nameof(myShape)} has an area of {myShape.GetArea()}");
            }

            Console.ReadLine();
        }
    }
}
