using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public partial class Course
    {
        public string DisplayName => $"{Department} - {Code} - {Name}";
    }

    public partial class Section
    {
        public string DisplayField => $"{Course.DisplayName} - {Faculty.Name} - {Term}";
    }
}
