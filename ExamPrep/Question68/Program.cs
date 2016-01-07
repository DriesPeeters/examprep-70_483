using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question68
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = TestIfWebsite("http://www.google.comhttp://www.amazon.com");
            foreach(var r  in result)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }

        public static List<String> TestIfWebsite(string url)
        {
            const string pattern = @"http://(www\.)?([^\.]+)\.com";
            List<string> result = new List<string>();

            MatchCollection myMatches = Regex.Matches(url, pattern);
            foreach(Match currentMatch in myMatches)
            {
                result.Add(currentMatch.Value);
            }
            return result;
        }
    }
}
