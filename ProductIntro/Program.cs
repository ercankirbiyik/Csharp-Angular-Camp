using System;

namespace ProductIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Apple";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Bicycle";

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Sofa";

            Product[] products = new Product[] { product1, product2, product3 };
            
            Console.WriteLine("*****For Loop*****");

            for(int i = 0; i<products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("*****Foreach Loop*****");

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("*****While Loop*****");

            int k = 0;
            while (k < products.Length)
            {
                Console.WriteLine(products[k].ProductName);
                k++;
            }

        }
    }

    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
