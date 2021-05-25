using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Api.Models;
using WebApiCore.Api.Repository;

namespace WebApiCore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeathersController : ControllerBase
    {
        public IRepository<Weather> Context {get;}

        public WeathersController(IRepository<Weather> context)
        {
            Context = context;
        }

        [HttpGet]
        public IEnumerable<Weather> Get()
        {
            return Context.All;
        }

        [HttpGet("{id}")]
        public ActionResult<Weather> Get(int id)
        {
            return new Weather { Id = id, Status = "Frosty", Temperature = 45.5f, MaxTemperature = 59.99f, MinTemperature = 25f };
        }

        [HttpPost]
        public void Post([FromQuery] Weather value) {}

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Weather value) {}

        [HttpDelete("{id}")]
        public void Delete(int id) {}
    }
}
