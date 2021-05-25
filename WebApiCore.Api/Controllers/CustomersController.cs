using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services;
using WebApiCore.Api.Models;
using WebApiCore.Api.Repository;

namespace WebApiCore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        public IRepository<Customer> Context {get;}

        public CustomersController(IRepository<Customer> context)
        {
            Context = context;
            //Context = IoCContainer.Resolve<IRepository<Customer>>();
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Context.All;
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
