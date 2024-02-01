using CarDealership.BL.Interfaces;
using CarDealership.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;
        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Manufacturer> GetAll()
        {
            return _manufacturerService.GetAll();
        }

        [HttpGet("GetById")]
        public Manufacturer GetById(int id)
        {
            return _manufacturerService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Manufacturer manufacturer)
        {
            _manufacturerService.Add(manufacturer);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _manufacturerService.Delete(id);
        }
    }
}
