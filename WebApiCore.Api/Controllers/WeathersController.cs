using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Api.Context;
using WebApiCore.Api.Models;

namespace WebApiCore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeathersController : ControllerBase
    {
        readonly WebApiCoreContext context;

        public WeathersController(WebApiCoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Weather> Get()
        {
            return context.Weathers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Weather> Get(int id)
        {
            return new Weather { Id = 777, Status = "Frosty", Temperature = 45.5f, MaxTemperature = 59.99f, MinTemperature = 25 };
        }

        [HttpPost]
        public void Post([FromQuery] Weather value) {}

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Weather value) {}

        [HttpDelete("{id}")]
        public void Delete(int id) {}
    }
}
