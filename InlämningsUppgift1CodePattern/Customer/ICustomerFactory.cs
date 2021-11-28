using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Customer
{
    public interface ICustomerFactory
    {
        public List<ICustomer> CustomerList { get; set; }
        public void RegisterCustomer();

        public void ListAllCustomers();

        //public void InitCustomerList();
    }
}
