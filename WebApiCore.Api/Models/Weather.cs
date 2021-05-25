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
        public float Temperature {get; set;}
        public float MinTemperature {get; set;}
        public float MaxTemperature {get; set;}
    }
}
