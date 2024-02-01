using CarDealership.BL.Interfaces;
using CarDealership.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Car> GetAll() 
        { 
            return _carService.GetAll(); 
        }

        [HttpGet("GetById")]
        public Car GetById(int id)
        {
            return _carService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Car car)
        {
            _carService.Add(car);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _carService.Delete(id);
        }
    }
}
