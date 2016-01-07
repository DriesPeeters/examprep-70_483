using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question114
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string orderRefNumber = null;
                ProcessOrders(orderRefNumber);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} An exception caught.", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} An exception caught.", e);
            }
            Console.ReadKey();
        }

        static void ProcessOrders (string orderRefNumber)
        {
            if(orderRefNumber == null) {
                throw new ArgumentNullException();
            }
        }

    }
}
