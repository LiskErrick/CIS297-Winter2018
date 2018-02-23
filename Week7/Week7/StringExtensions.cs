using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public static class StringExtensions
    {
        public static string ToRandomCase(this string text)
        {
            // this is the right way to do a bunch of string appending
            StringBuilder builder = new StringBuilder();

            Random random = new Random();

            foreach( var character in text.ToArray())
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        builder.Append(character.ToString().ToLower());
                        break;
                    case 2:
                        builder.Append(character.ToString().ToUpper());
                        break;
                }
            }

            return builder.ToString();
            
            
        }
    }
}
