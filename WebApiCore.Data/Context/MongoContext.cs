using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Context
{
    public class MongoContext
    {
        public IMongoCollection<Customer> Customers {get;}
        public MongoContext(MongoDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            Customers = client.GetDatabase(settings.DatabaseName).GetCollection<Customer>(settings.CustomersCollectionName);
        }
    }
}
