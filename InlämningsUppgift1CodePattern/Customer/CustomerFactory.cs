using System;
using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Customer
{
    public class CustomerFactory : ICustomerFactory
    {

        private ICustomer Customer;
        public List<ICustomer> CustomerList { get; set; }

        //private Func<string, string, string, ICustomer> CustomerFunc;

        //public CustomerFactory(ICustomerList customerList, Func<string, string, string, ICustomer> customerFunc)
        //{
        //    CustomerList = customerList;
        //    CustomerList.Customers = new List<ICustomer>();
        //    CustomerFunc = customerFunc;
        //}

        public CustomerFactory(ICustomer customer)
        {
            Customer = customer;
            CustomerList = new List<ICustomer>();
        }

        public void RegisterCustomer()
        {
            Console.WriteLine("\n\nEnter name of customer: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter address:");
            var address = Console.ReadLine();
            Console.WriteLine("Enter phonenumber:");
            var phoneNr = Console.ReadLine();



            //CustomerList.Customers.Add(CustomerFunc(name, address, phoneNr));
            CustomerList.Add(new Customer { Name = name, Address = address, PhoneNr = phoneNr });
            Console.WriteLine("Customer added! Choice another option above or press C to exit!");
        }

        public void ListAllCustomers()
        {


            Console.WriteLine("\n\nHere are all the registrated customers: ");
            Console.WriteLine("--------------------------------------------");
            foreach (var Customer in CustomerList)
            {
                Console.WriteLine($"Name: {Customer.Name} Address: {Customer.Address} Phonenumber: {Customer.PhoneNr}");
            }
        }
    }
}
