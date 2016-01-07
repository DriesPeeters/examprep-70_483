using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question151
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLogger logger = new Logger();
            //Log started
            logger.Log("Log started");
            //Base: Log Continuing
            logger.Log("Base: Log Continuing");
            //((BaseLogger)logger).Log("Log Continuing"); //=> Just prints: Log Continuing
            //Finished
            //logger.LogCompleted(); // => Completed
            ((Logger)logger).LogCompleted();

            Console.ReadKey();
        }

        abstract class BaseLogger
        {
            public virtual void Log(string message)
            {
                Console.WriteLine("Base: " + message);
            }
            public void LogCompleted()
            {
                Console.WriteLine("Completed");
            }
        }

        class Logger : BaseLogger
        {
            public override void Log(string message)
            {
                Console.WriteLine(message);
            }
            public new void LogCompleted()
            {
                Console.WriteLine("Finished");
            }
        }
    }
}
