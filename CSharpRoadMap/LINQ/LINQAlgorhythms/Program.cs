using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Acer Laptop";
            product1.CategoryId = 1;
            product1.UnitPrice = 10;
            product1.UnitsInStock = 259;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Asus Laptop";
            product2.CategoryId = 1;
            product2.UnitPrice = 15;
            product2.UnitsInStock = 3333;
            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Macbook Pro";
            product3.CategoryId = 1;
            product3.UnitPrice = 2300;
            product3.UnitsInStock = 98;
            Product product4 = new Product();
            product4.Id = 4;
            product4.ProductName = "Samsung Phone";
            product4.CategoryId = 2;
            product4.UnitPrice = 1;
            product4.UnitsInStock = 65;
            Product product5 = new Product();
            product4.Id = 5;
            product4.ProductName = "Apple Iphone";
            product5.CategoryId = 2;
            product4.UnitPrice = 1500;
            product4.UnitsInStock = 22;

            //var result = products.Find(p => p.Id == 1);
            //Console.WriteLine(result.UnitPrice);

            //Console.WriteLine("------------------");

            //var result2 = products.FindAll(p => p.UnitsInStock < 100 && p.UnitPrice>10);

            //foreach (var x in result2)
            //{
            //    Console.WriteLine(x.ProductName);
            //}


            List<Category> categories = new List<Category>{
                    new Category { CategoryName = "Phone", CategoryId = 2 },
                    new Category { CategoryName = "Laptop", CategoryId = 1 }

            };
            List<Product> products = new List<Product> { product1, product2, product3, product4 };

            // LINQ Query Syntax
            var result = from p in products
                                        join c in categories
                                        on p.CategoryId equals c.CategoryId
                                       
                                        select new ProductDTO { ProductName = p.ProductName, CategoryName = c.CategoryName, Id = p.Id, UnitPrice = p.UnitPrice };

            // I Connect Categoriy and Product Class on their CategoryIDies and created a new DTO class that contain same feature I want to show


            foreach (var productDto in result) // I m joint 2 Datas(Product, Category) and connect DTO class, so i can control the hole table by way of DTO class
            {
                Console.WriteLine("{0} ---- {1}", productDto.ProductName, productDto.CategoryName);
            }




        }


        

    }
}
public class ProductDTO
// ProductDTO class holds common features from both classes
{
    public int Id { get; set; } //product
    public string ProductName { get; set; } // product
    public string CategoryName { get; set; } // Category
    public int UnitPrice { get; set; } // product

}
public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public int UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

public class Category
{
    public string CategoryName { get; set; }
    public int CategoryId { get; set; }

}

