using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question233
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Match: {0}", TestIfWebsite("http://www.google.com").Count);
            Console.ReadKey();
        }

        public static List<string> TestIfWebsite(string url)
        {
            const string pattern = @"http://(www\.)?([^\.]+)\.com";
            List<string> result = new List<string>();

            MatchCollection myMatches = Regex.Matches(url, pattern);
            result = (from Match match in myMatches
                      select match.Value).ToList<string>(); // C => Correct!
            return result;
        }
    }
}
