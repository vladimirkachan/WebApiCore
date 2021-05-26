using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCore.Data.Context
{
    public class MongoDBSettings
    {
        public string CustomersCollectionName {get; set;}
        public string ConnectionString {get; set;}
        public string DatabaseName {get; set;}
    }
}
