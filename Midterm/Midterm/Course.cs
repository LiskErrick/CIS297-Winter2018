using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    // Q 33 - 34 - 35
    public class Course
    {
        public string Number { get; private set; }
        public string Title { get; private set; }
        public int Credits { get; private set; }

        public Course( string Number, string Title, int Credits)
        {
            this.Number = Number;
            this.Title = Title;
            this.Credits = Credits;
        }

        public override string ToString()
        {
            return $"Course: {Number} - {Title} - Credit: {Credits}";
        }
    }
}
