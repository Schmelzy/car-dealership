using CarDealership.BL.Interfaces;
using CarDealership.Models.Requests;
using CarDealership.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.BL.Services
{
    public class CarStoreService : ICarStoreService
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly ICarService _carService;

        public CarStoreService(IManufacturerService manufacturerService, ICarService carService)
        {
            _manufacturerService = manufacturerService;
            _carService = carService;
        }

        public int GetAllCarsCount(int inputCount)
        {
            var carsCount = _carService.GetAll();
            return carsCount.Count + inputCount;
        }

        public GetAllCarsByManufacturerResponse GetAllCarsByManufacturer(GetAllCarsByManufacturerRequest request)
        {
            var result = new GetAllCarsByManufacturerResponse();
            result.Manufacturer = _manufacturerService.GetById(request.ManufacturerId);
            result.Cars = _carService.GetAllCarsByManufacturer(request.ManufacturerId);
            return result;
        }
    }
}
