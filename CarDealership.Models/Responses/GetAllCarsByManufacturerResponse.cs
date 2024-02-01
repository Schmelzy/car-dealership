using CarDealership.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models.Responses
{
    public class GetAllCarsByManufacturerResponse
    {
        public Manufacturer Manufacturer { get; set; }
        public List<Car> Cars { get; set; }
    }
}
