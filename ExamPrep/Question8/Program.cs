using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{ ""FirstName"" : ""David"",
                          ""LastName"" : ""Jones"",
                          ""Values"" : [0, 1, 2] }";

            var ser = new JavaScriptSerializer();
            var name = ser.Deserialize<Name>(json);
            Console.ReadKey();
        }

        public class Name
        {
            public int[] Values { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
