using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Question146
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Name { FullName = "John Doe" };
            var ms = WriteName(name);

            ms.Position = 0;
            var sr = new StreamReader(ms);
            Console.WriteLine(sr.ReadToEnd());
            
            Console.ReadKey();
        }

        private static MemoryStream WriteName(Name name)
        {
            var ms = new MemoryStream();
            var binary = XmlDictionaryWriter.CreateBinaryWriter(ms);
            var ser = new DataContractSerializer(typeof(Name));
            ser.WriteObject(binary, name);
            binary.Flush(); // Flush had to be added!
            return ms;
        }
    }
    [DataContract]
    public class Name
    {
        [DataMember]
        public string FullName { get; set; }
    }
}
