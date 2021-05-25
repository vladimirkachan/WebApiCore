using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCore.Api.Models
{
    public class Weather
    {
        [Key] 
        public int Id { get; set; }
        public string Status {get; set;}
        public double Temperature {get; set;}
        public double MinTemperature {get; set;}
        public double MaxTemperature {get; set;}
    }
}
