using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question91
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan l = new Loan();
            l.OnMaximumTermReached += L_OnMaximumTermReached;
            l.Term = 20;
            l.OnMaximumTermReached -= L_OnMaximumTermReached;

            Console.ReadKey();
        }

        private static void L_OnMaximumTermReached(object source, EventArgs e)
        {
            Console.WriteLine("Maximum term reached");
        }
    }
}
