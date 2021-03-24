using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWhereMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Bigisayar"},
                new Category {CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Monster Notebook",ProductPrice = 11000,Stock = 3},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "Apple Notebook",ProductPrice = 15000,Stock = 6},
                new Product{ProductId = 3,CategoryId = 1,ProductName = "MSI Notebook",ProductPrice = 13000,Stock = 1},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Samsung Telefon",ProductPrice = 6000,Stock = 2},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Apple Telefon",ProductPrice = 10000,Stock = 4},

                
            };

            GetProducts(products);
            Console.WriteLine("-------------------");
            AlgoGet(products);
        }

        static List<Product> AlgoGet(List<Product> products)
        {
            List<Product> productFilter = new List<Product>();

            foreach (var value in products)
            {
                if (value.ProductPrice >= 1000 && value.Stock > 3)
                {
                    productFilter.Add(value);
                    Console.WriteLine(value.ProductName);
                }


            }
            return productFilter;
            
        }

       static List<Product> GetProducts(List<Product> products)
       {
           var result = products.Where(p => p.ProductPrice >= 1000 && p.Stock > 3).ToList();
           
            foreach (var xt in result)
           {
               Console.WriteLine(xt.ProductName);
           }

            return result;

       }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Stock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
