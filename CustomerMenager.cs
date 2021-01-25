using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerMenager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("musteri eklendi ");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("musteri silindi ");
        }
        public void Uptade(Customer customer)
        {
            Console.WriteLine("musteri güncellendi");
        }
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("MÜŞTERİNİN ADI :" +customer.customerName);
                Console.WriteLine("MÜŞTERİNİN SOYADI : " +customer.surname);
                Console.WriteLine("MÜŞTERİ ID Sİ : " +customer.Id);
            }
        }

    }
}
