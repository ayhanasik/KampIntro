using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer) 
        {
            Console.WriteLine(customer.customerNo + " nolu " + customer.customerName +" müşterisi eklendi!");
            Console.WriteLine("____  Müşteri Eklendi sonu  ____");
        }
        public void DeleteCustomer(Customer customer) 
        {
            customer.statu = "Pasif";
            Console.WriteLine("____  Müşteri Silindi sonu  ____");
        }
        public void ListCustomer(Customer customer) 
        {
            Console.WriteLine("Müşteri Adı   : " + customer.customerName);
            Console.WriteLine("Müşteri No    : " + customer.customerNo);
            Console.WriteLine("Müşteri Statü : " + customer.statu);
            Console.WriteLine("Müşteri Bakiye: " + customer.balance);
            Console.WriteLine("____  Müşteri Listelendi!  ____");
        }

    }
}
