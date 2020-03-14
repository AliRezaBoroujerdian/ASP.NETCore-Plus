using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using GraphQLDemo01.Models;

namespace GraphQLDemo01.Repository
{
    public class Customer
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public Customer()
        {
            customers.Add(new CustomerModel() { CustomerID = 1, FirstName = "AliReza", LastName = "Boroujerdian", Age = 27, City = "Tehran" });
            customers.Add(new CustomerModel() { CustomerID = 2, FirstName = "Mahtab", LastName = "Kashani", Age = 27, City = "Kashan" });
            customers.Add(new CustomerModel() { CustomerID = 3, FirstName = "Nader", LastName = "Ahmadi", Age = 27, City = "Shiraz" });
        }

        public List<CustomerModel> List() => customers;
    }
}
