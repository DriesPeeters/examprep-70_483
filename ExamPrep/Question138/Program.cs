using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Question138
{
    class Program
    {
        static void Main(string[] args)
        {
            //OptionA("https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg", ".\\optionA.jpg"); //-> ArgumentException: Additional information: Stream was not writable.
            OptionB("https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg", ".\\optionB.jpg"); // -> File with content "System.Byte[]"
            OptionC("https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg", ".\\optionC.jpg"); // -> Correct!
            //OptionD("https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg", ".\\optionD.jpg"); ////-> ArgumentException: Additional information: Stream was not writable.
        }


        private static void OptionA(string url, string file)
        {
            WebRequest request = HttpWebRequest.Create(url);
            StreamWriter writer = new StreamWriter(request.GetResponse().GetResponseStream());
            writer.WriteLine(file);
            writer.Dispose();
        }

        private static void OptionB(string url, string file)
        {
            WebClient client = new WebClient();
            StreamWriter writer = new StreamWriter(file);
            writer.Write(client.DownloadData(url));
            writer.Dispose();
            client.Dispose();
        }

        private static void OptionC(string url, string file)
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, file);
            client.Dispose();
        }

        private static void OptionD(string url, string file)
        {
            WebRequest request = HttpWebRequest.Create(url);
            StreamWriter writer = new StreamWriter(request.GetResponse().GetResponseStream());
            writer.Write(file);
            writer.Dispose();
        }
    }
}
