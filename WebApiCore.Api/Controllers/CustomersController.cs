using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Data.Models;
using WebApiCore.Data.Repository;

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
        }

        [HttpPost("mega-post/{routeName}")] // http://localhost:5000/api/customers/mega-post
        public IEnumerable<Customer> Post(
        [FromQuery] string queryName,
        [FromRoute] string routeName,
        [FromForm] Customer a,
        [FromBody] Customer b,
        [FromHeader] string headerName)
        {
            return Context.All;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Context.All;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return Context.FindById(id);
        }

        [HttpPost]
        public void Post([FromQuery] Customer value)
        {
            Context.Update(value); 
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            Context.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Context.Delete(Context.FindById(id));
        }
    }
}
