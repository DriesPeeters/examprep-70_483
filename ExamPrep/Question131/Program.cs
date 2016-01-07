using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question131
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new { From = "John Morris", To = "Mary North", Content = "Hello World!" };
            SendMessage(message);

            dynamic msg = new ExpandoObject();
            msg.From = "John Morris";
            msg.To = "Mary North";
            msg.Content = "Hello World!";
            SendMessage(msg);

            Console.ReadKey();
        }

        private static void SendMessage(dynamic msg)
        {
            Console.WriteLine(msg.From);
            Console.WriteLine(msg.To);
            Console.WriteLine(msg.Content);
        }
    }
}
