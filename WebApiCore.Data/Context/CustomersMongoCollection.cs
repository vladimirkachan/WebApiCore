using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public Customer FirstOrDefault(Expression<Func<Customer,bool>> predicator) => customers.Find(predicator).FirstOrDefault();
        public Customer Add(Customer customer)
        {
            customers.InsertOne(customer);
            return customer;
        }
        public void Update(Customer customer) => customers.ReplaceOne(c => c.Id == customer.Id, customer);
        public void Remove(Customer customer) => customers.DeleteOne(c => c.Id == customer.Id);
    }
}
