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

            for( int index = 0; index < shapes.Length; index++ )
            { 
                Console.WriteLine($" has an area of {shapes[index].GetArea()}");
            }

            Console.ReadLine();
        }
    }
}
