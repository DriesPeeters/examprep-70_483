using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Order[]
            {
                new Order {OrderDate = null },
                new Order {OrderDate = DateTime.Now }
            };

            var newOrders = (from order in orders
                            where order.OrderDate.HasValue && order.OrderDate.Value.Year >= 2016
                            select order).ToArray();


        }


    }
}
