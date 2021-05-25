using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCore.Api.Context;
using WebApiCore.Api.Models;

namespace WebApiCore.Api.Repository
{
    public class WeatherRepository : IRepository<Weather> 
    {
        readonly WebApiCoreContext context;

        public WeatherRepository(WebApiCoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<Weather> All => context.Weathers.ToList();
        public void Add(Weather entity)
        {
            context.Weathers.Add(entity);
        }
        public void Delete(Weather entity)
        {
            context.Weathers.Remove(entity);
            context.SaveChanges();
        }
        public void Update(Weather entity)
        {
            context.Weathers.Update(entity);
            context.SaveChanges();
        }
        public Weather FindById(int id)
        {
            return context.Weathers.FirstOrDefault(e => e.Id == id);
        }
        public Weather FindById(string id)
        {
            if (!int.TryParse(id, out var i)) throw new ArgumentException(id);
            return FindById(i);
        }
    }
}
