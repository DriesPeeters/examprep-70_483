using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question232
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category { ID = 1, Name = "Food" },
                new Category { ID = 2, Name = "Clothing" }
            };
            List<Product> products = new List<Product>()
            {
                new Product {Name = "Strawberry", CategoryID = 1 },
                new Product {Name = "Banana", CategoryID = 1 },
                new Product {Name = "Pants", CategoryID = 2 },
            };


            var productsWithCategories =
                (from product in products
                 join category in categories
                     on product.CategoryID equals category.ID
                 select new
                 {
                     Name = product.Name,
                     Category = category.Name
                 }).ToList();

            Console.ReadKey();
        }

        public class Product
        {
            public string Name { get; set; }
            public int CategoryID { get; set; }
        }
        public class Category
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
