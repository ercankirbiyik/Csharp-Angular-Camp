using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ercan";
            customer1.LastName = "Kırbıyık";
            customer1.NationalIdentity = 12331321321;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "FirstName";
            customer2.LastName = "LastName";
            customer2.NationalIdentity = 999999999999;

            Customer[] customers = { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*");

                Console.WriteLine("Customer Id : " + customer.Id);
                Console.WriteLine("Customer Name Surname : " + customer.FirstName + " " + customer.LastName);

            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer2);
            customerManager.Update(customer1);
        }
           
    }
}
