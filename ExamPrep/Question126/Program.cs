using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Question126
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] people =
            {
                new Contact { ContactId =1,FirstName="Dries", LastName="Johnes" }
            };

            //Good version
            XNamespace ew = "ContactList";
            XElement root = new XElement(ew + "Root",
                new XElement("contacts",
                from c in people
                orderby c.ContactId
                select new XElement ("contact",
                    new XAttribute("contactId", c.ContactId),
                    new XElement("firstName", c.FirstName),
                    new XElement("lastname", c.LastName))
                ));

            Console.WriteLine(root);

            // Possibly meant in question...
            XElement root2 = new XElement(ew + "Root");
            XElement contacts =
                new XElement("contacts",
                from c in people
                orderby c.ContactId
                select new XElement("contact",
                    new XAttribute("contactId", c.ContactId),
                    new XElement("firstName", c.FirstName),
                    new XElement("lastname", c.LastName))
                );
            root2.Add(contacts);
            Console.WriteLine(root2);

            Console.ReadKey();
        }

        class Contact
        {
            public int ContactId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
