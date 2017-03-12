using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.Models;
using My.Repository;

namespace My.BusinessLayer
{
    public interface ICustomerIdentifyStrategy
    {
        void AddCustomer(Customer customer);
    }

    public class CustomerIdentifyStrategy : ICustomerIdentifyStrategy
    {
        private IRepository<My.Entities.Customer> _repository;
        public CustomerIdentifyStrategy(IRepository<My.Entities.Customer> repository)
        {
            _repository = repository;
        }
        public void AddCustomer(Customer customer)
        {
            var dbCustomer = new My.Entities.Customer();
            dbCustomer.CustomerId = customer.CustomerId;
            dbCustomer.Firstname = customer.Firstname;
            dbCustomer.Lastname = customer.Lastname;
            dbCustomer.Age = customer.Age;
            var address = new My.Entities.Address
            {
                AddressId = 1,
                HouseNo_Name = "120",
                Street = "Highfield Road",
                Area = "Feltham",
                Country = "UK"
            };
            dbCustomer.Address = address;

            _repository.Add(dbCustomer);
           

        }




    }
}


