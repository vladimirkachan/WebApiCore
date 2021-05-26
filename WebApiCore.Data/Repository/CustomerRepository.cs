using System.Collections.Generic;
using System.Linq;
using WebApiCore.Data.Context;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        readonly MongoContext context;

        public CustomerRepository(MongoContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> All => context.Customers.ToList();
        public void Add(Customer entity)
        {
            context.Customers.Add(entity);
        }
        public void Delete(Customer entity)
        {
            context.Customers.Remove(entity); 
        }
        public void Update(Customer entity)
        {
            context.Customers.Update(entity);
        }
        public Customer FindById(int id)
        {
            return FindById(id.ToString());
        }
        public Customer FindById(string id)
        {
            return context.Customers.FirstOrDefault(e => e.Id == id);
        }
    }
}
