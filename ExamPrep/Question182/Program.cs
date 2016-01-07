using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question182
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array1 = new ArrayList();
            int var1 = 10;
            int var2;
            array1.Add(var1);
            // var2 = ((List<int>)array1)[0]; // A => Wrong!
            // var2 = array1[0].Equals(typeof(int)); // B => Wrong!
            var2 = Convert.ToInt32(array1[0]); //C => Correct!!
            //var2 = ((int[])array1)[0]; // D => Wrong!
            Console.WriteLine(var2);

            Console.ReadKey();
        }
    }
}
