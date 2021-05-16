using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitInStock = 500;
            product1.UnitPrice = 3;

            Product product2 = new Product {Id=2, CategoryId=5, UnitInStock=5, ProductName="Sofa", UnitPrice=1200 };

            ProductManager productManager = new ProductManager();
            Console.WriteLine(product1.ProductName);

            productManager.Add(product1);
           
            productManager.Update(product1);
           
            productManager.Delete(product1);
            

        }
    }
}
