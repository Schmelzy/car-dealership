using CarDealership.BL.Interfaces;
using CarDealership.DL.Interfaces;
using CarDealership.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.BL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Add(Car car)
        {
            _carRepository.Add(car);
        }

        public void Delete(int id)
        {
            _carRepository.Delete(id);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public List<Car> GetAllCarsByManufacturer(int manufacturerId)
        {
            return _carRepository.GetAllCarsByManufacturer(manufacturerId);
        }

        public Car GetById(int id)
        {
            return _carRepository.GetById(id);
        }
    }
}
