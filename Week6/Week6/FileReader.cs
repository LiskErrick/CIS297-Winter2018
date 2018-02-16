using System;
using System.Collections.Generic;

// add this for IO stuff
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class FileReader
    {
        public FileReader()
        {
            
        }

        public string ReadFile()
        {
            try
            {
                var text = File.ReadAllText("test.txt");
                return text;
            }
            catch( FileNotFoundException e)
            {
                return e.StackTrace;
            }
        }

        public void WriteFile(string text)
        {
            File.AppendAllText("output.txt", text);
        }
    }
}
