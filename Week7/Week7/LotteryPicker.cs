using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public delegate void Log(string message);
    public delegate void Action<T>(T message);
    public delegate TResult Func<TResult>(TResult message);

    public class LotteryPicker
    {
        private Random random;
        Log logger;
        private bool isConsoleLogging;
        private bool isFileLogging;

        public LotteryPicker()
        {
            random = new Random();
            isConsoleLogging = false;
            isFileLogging = false;
            logger += logToFile;
        }

        public void ToggleFileLogging()
        {
            if ( isFileLogging )
            {
                logger -= logToFile;
            }
            else
            {
                logger += logToFile;
            }
            
        }

        public void ToggleConsoleLogging()
        {
            if ( isConsoleLogging )
            {
                logger -= logToConsole;
            }
            else
            {
                logger += logToConsole;
            }
            
        }

        public int pickNumber()
        {
            var result = random.Next(1,10);
            logger?.Invoke($"{DateTime.Now.ToString()} {result.ToString()}");

            return result;
        }

        public static void logToConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static void logToFile(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
        }
    }
}
