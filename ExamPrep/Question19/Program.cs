using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question19
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(4.2f);
            Console.ReadKey();
        }

        public static void Calculate(float amount)
        {
            object amountRef = amount;
            float f = (float)amountRef;
            int balance = (int)f;
            Console.WriteLine(balance);
        }
    }
}
