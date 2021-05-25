using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiCore.Api.Context;
using WebApiCore.Api.Models;

namespace WebApiCore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        readonly WebApiCoreContext context;

        public CustomersController(WebApiCoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return context.Customers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return new Customer {BirthDate = DateTime.Now, Email = "kachan@mail.com", Name = "Vova", Id = id.ToString()};
        }

        [HttpPost]
        public void Post([FromQuery] Customer value) {}

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value) {}

        [HttpDelete("{id}")]
        public void Delete(int id) {}
    }
}
