using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCore.Api.Context;
using WebApiCore.Api.Models;

namespace WebApiCore.Api.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        readonly WebApiCoreContext context;

        public CustomerRepository(WebApiCoreContext context)
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
            context.SaveChanges();
        }
        public void Update(Customer entity)
        {
            context.Customers.Update(entity);
            context.SaveChanges();
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
