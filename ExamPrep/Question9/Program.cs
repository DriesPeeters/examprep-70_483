using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Name
            {
                FirstName = "John",
                LastName = "Appleseed"
            };

            using (MemoryStream stream = new MemoryStream())
            {
                var serializer = new DataContractSerializer(typeof(Name));
                serializer.WriteObject(stream, name);

                stream.Position = 0;
                StreamReader reader = new StreamReader(stream);
                Console.WriteLine($"{reader.ReadToEnd()}");

            }

            Console.ReadKey();
            

        }

        [DataContract(Namespace = "http://www.contoso.com/2012/06")]
        public class Name
        {
            [DataMember]
            public string FirstName { get; set; }
            [DataMember]
            public string LastName { get; set; }
        }
    }
}
