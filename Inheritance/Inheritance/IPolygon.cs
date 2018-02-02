using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IPolygon
    {
        double GetPerimeter();
        double GetArea();
        int NumberOfSides();
        string Name();
    }
}
