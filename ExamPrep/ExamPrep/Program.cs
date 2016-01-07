using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] loanAmounts = { 303m, 1000m, 85579m, 501.51m, 603m, 1200m, 400m, 22m };
            IEnumerable<decimal> loanQuery =
                from amount in loanAmounts
                where amount % 2 == 0
                orderby amount ascending
                select amount;

            Console.WriteLine(string.Join(",",loanQuery.ToArray()));

            Console.ReadKey();
        }
    }
}
