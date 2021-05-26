using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Context
{
    public class CustomersMongoCollection
    {
        readonly IMongoCollection<Customer> customers;

        public CustomersMongoCollection(IMongoCollection<Customer> customers)
        {
            this.customers = customers;
        }

        public List<Customer> ToList() => customers.Find(c => true).ToList();
        public Customer Get(string id) => customers.Find(c => c.Id == id).FirstOrDefault();
    }
}
