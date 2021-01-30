using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.customerName = "Engin Demiroğ";
            customer.customerNo = 1;
            customer.statu = "Aktif";
            customer.balance = 100.00;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer);
            customerManager.ListCustomer(customer);
            customerManager.DeleteCustomer(customer);
            customerManager.ListCustomer(customer);


            Console.WriteLine("....   THE END   ....");
        }
    }
}
