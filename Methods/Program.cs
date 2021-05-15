using System;

//Metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 12;
            string explanation = "Red Apple";

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Red Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 18;
            product2.Explanation = "Diyarbakır Watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("************************");
            }

            Console.WriteLine("************Methods*************");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Apple", "Green Apple", 12, 10);
            sepetManager.Add2("Apple-2", "Red Apple-2", 15, 20);

        }
    }
}
