using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    // Q36
    public class Seminar : Course
    {
        public string GuestLecturer { get; private set; }
        public Seminar(string Number, string Title, int Credits, string GuestLecturer) : base(Number, Title, Credits)
        {
            this.GuestLecturer = GuestLecturer;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Guest Lecturer: {GuestLecturer}";
        }
    }
}
