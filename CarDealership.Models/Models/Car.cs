using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string EngineType { get; set; } = string.Empty;

        public int Horsepower { get; set; }

        public int ManufacturerId { get; set; }
    }
}
