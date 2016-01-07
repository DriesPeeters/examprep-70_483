using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Question55
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Customer p = new Customer()
                {
                    Id = Guid.NewGuid(),
                    Name = "David Jones",
                    DateOfBirth = new DateTime(1977, 6, 11)
                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }

            Console.WriteLine(xml);
            Console.WriteLine("");

            using (StringReader stringReader = new StringReader(xml))
            {
                Customer p = (Customer)serializer.Deserialize(stringReader);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    [Serializable]
    [XmlRoot("Prospect", Namespace ="http://prospect")]
    public class Customer
    {
        [XmlAttribute("ProspectId")]
        public Guid Id { get; set; }
        [XmlElement("FullName")]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [XmlIgnore]
        public int Tin { get; set; }
    }
}
