using System;

namespace ClassMethodDemo
{
    internal class CustomerManagerBase
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " added.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " deleted.");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " listed.");
            }
        }
    }
}