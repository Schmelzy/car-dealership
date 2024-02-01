using CarDealership.DL.Interfaces;
using CarDealership.DL.MemoryDB;
using CarDealership.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CarDealership.DL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            InMemoryDB.CarData.Add(car);
        }

        public void Delete(int id)
        {
            var car = GetById(id);
            if (car != null)
            {
                InMemoryDB.CarData.Remove(car);
            }
        }

        public List<Car> GetAll()
        {
            return InMemoryDB.CarData.ToList();
        }

        public List<Car> GetAllCarsByManufacturer(int manufacturerId)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return InMemoryDB.CarData.FirstOrDefault(c => c.Id == id);
        }
    }
}
