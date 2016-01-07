using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question96
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Subscriber();
            s.Subscribe();
            s.Execute();       

            Console.ReadKey();
        }
    }

    public class Alert
    {
        public event EventHandler<EventArgs> SendMessage;

        public void Execute()
        {
            SendMessage(this, new EventArgs());
        }
    }

    public class Subscriber
    {
        Alert alert = new Alert();

        public void Subscribe()
        {
            alert.SendMessage += (sender, e) => { Console.WriteLine("First"); };
            alert.SendMessage += (sender, e) => { Console.WriteLine("Second"); };
            alert.SendMessage += (sender, e) => { Console.WriteLine("Third"); };
            alert.SendMessage += (sender, e) => { Console.WriteLine("Third"); };
        }

        public void Execute()
        {
            alert.Execute();
        }
    }
}
