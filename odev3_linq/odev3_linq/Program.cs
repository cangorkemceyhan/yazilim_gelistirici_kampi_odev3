using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_linq
{
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsİnStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set;}
        public string CategoryName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId = 1,CategoryName="Bilgisayar"},
                new Category{ CategoryId = 2,CategoryName="Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=8000,UnitsİnStock=5},
                new Product{ ProductId = 2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=6000,UnitsİnStock=25},
                new Product{ ProductId = 3,CategoryId=1,ProductName="Apple Macbook Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsİnStock=3},
                new Product{ ProductId = 4,CategoryId=2,ProductName="Xiaomi Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=7000,UnitsİnStock=33},
                new Product{ ProductId = 5,CategoryId=2,ProductName="Huawei Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsİnStock=41},
            };

            foreach(var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsİnStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.ReadKey();
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product=>product.UnitPrice>5000&&product.UnitsİnStock>3).ToList();
        }
    }
}
