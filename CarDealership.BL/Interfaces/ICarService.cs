﻿using CarDealership.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.BL.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetById(int id);

        void Add(Car car);

        void Delete(int id);

        List<Car> GetAllCarsByManufacturer(int manufacturerId);
    }
}
