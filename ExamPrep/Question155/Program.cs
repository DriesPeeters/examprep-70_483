using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question155
{
    class Program
    {
        static void Main(string[] args)
        {
            string price;
            do
            {
                Console.Write("Enter unit price: ");
                price = Console.ReadLine();

                Regex reg = new Regex(@"^\d+(\.\d\d)?$"); // Correct answer: C
                if (reg.IsMatch(price))
                //if(Regex.IsMatch(price, @"^(-)?\d+(\.\d\d)?$")) // B is incorrect!
                {
                    Console.WriteLine("Valid price");
                }
                else
                {
                    Console.WriteLine("Invalid price");
                }
            } while (price != "exit");
            

        }
    }
}
