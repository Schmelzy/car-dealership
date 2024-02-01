using CarDealership.BL.Interfaces;
using CarDealership.Models.Requests;
using CarDealership.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarStoreController : ControllerBase
    {
        private readonly ICarStoreService _carStoreService;

        public CarStoreController(ICarStoreService carStoreService)
        {
            _carStoreService = carStoreService;
        }

        [HttpPost("GetAllCarsByManufacturer")]
        public GetAllCarsByManufacturerResponse GetAllCarsByManufacturer([FromBody] GetAllCarsByManufacturerRequest request)
        {
            return _carStoreService.GetAllCarsByManufacturer(request);
        }

        [HttpPost("TestEndPoint")]
        public string TestEndPoint([FromBody] TestRequest request)
        {
            return "Ok";
        }
    }
}
