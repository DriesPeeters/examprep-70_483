using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question58
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bValidInteger = false;
            int value = 0;
            do
            {
                Console.WriteLine("Enter an integer:");
                bValidInteger = GetValidInteger(ref value);
            } while (!bValidInteger);
            Console.WriteLine("You entered a valid integer, {0}", value);
            Console.ReadKey();
        }

        private static bool GetValidInteger(ref int value)
        {
            string sLine = Console.ReadLine();
            int number;
            if(!int.TryParse(sLine, out number))
            {
                return false;
            } else
            {
                value = number;
                return true;
            }
        }
    }
}
