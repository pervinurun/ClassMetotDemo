using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.customerName = "Pervin";
            customer.surname = "Urun";
            customer.Id = 12345;

            Customer customer1 = new Customer();
            customer1.customerName = "Selma";
            customer1.surname = "Yore";
            customer1.Id = 1456;

            Customer[] customers = new Customer[2];
            customers[0] = customer;
            customers[1] = customer1;


            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.Add(customer);
            customerMenager.Uptade(customer1);
            customerMenager.List(customers);
            customerMenager.Delete(customer);

           
           
        }
    }
}
