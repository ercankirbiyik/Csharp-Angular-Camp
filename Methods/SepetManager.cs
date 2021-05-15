using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations, Added to cart : " + product.Name);
        }

        public void Add2(string productName, string explanation, double price, int stockQuantity)
        {
            Console.WriteLine("Congratulations, Added to cart : " + productName);
        }
    }
}
