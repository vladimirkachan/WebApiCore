using System.ComponentModel.DataAnnotations;

namespace WebApiCore.Data.Models
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
