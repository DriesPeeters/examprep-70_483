using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question139
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatCoinsA("Peter", 0)); // Correct!
            Console.WriteLine(FormatCoinsB("Peter", 0));
            //Console.WriteLine(FormatCoinsC("Peter", 0)); //FormatException: input string was not in a correct format.
            //Console.WriteLine(FormatCoinsD("Peter", 0));//FormatException: Index (zero based) must be greater than or equal to zero and less than the size of the argument list.
            Console.ReadKey();
        }

        public static string FormatCoinsA(string name, int coins)
        {
            return String.Format("Player {0}, collected {1} coins.", name, coins.ToString("###0"));
        }
        public static string FormatCoinsB(string name, int coins)
        {
            return String.Format("Player {0}, collected {1:000#} coins.", name, coins);
        }
        public static string FormatCoinsC(string name, int coins)
        {
            return String.Format("Player {name}, collected {coins.ToString('000'} coins.");
        }
        public static string FormatCoinsD(string name, int coins)
        {
            return String.Format("Player {1}, collected {2:D3} coins.", name, coins);
        }
    }
}
