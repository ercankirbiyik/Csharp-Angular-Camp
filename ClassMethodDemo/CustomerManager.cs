using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.Lastname + " added.");
        }
         public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.Lastname + " deleted.");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.Lastname + " listed.");
            }
        }
    }
}
