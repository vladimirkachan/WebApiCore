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

        [HttpPost("mega-post")]
        [HttpPost("mega-post/{routeName}")] // POST http://localhost:5000/api/customers/mega-post
        public IEnumerable<Customer> Post(
        [FromQuery] string queryName,   // - https://domain.com/api/customers/mega-post?queryName=NameFromQuery?id=1 
        [FromRoute] string routeName,   // - https://domain.com/api/customers/mega-post?NameFromRouter 
        [FromForm] Customer a,          // - https://domain.com/api/customers/mega-post Form-Body:  Id: 15  Name: NameFromForm
        [FromBody] Customer b,          // - https://domain.com/api/customers/mega-post Body:   { Id: 15, name: "NameFromBody" }
        [FromHeader] string headerName) // - https://domain.com/api/customers/mega-post Headers: headerName: NameFromHeader
        {
            return Context.All;
        }

        [HttpGet]
        public ActionResult< IEnumerable<Customer>> Get()
        {
            return Ok(Context.All);
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
