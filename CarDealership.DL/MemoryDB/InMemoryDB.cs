using CarDealership.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<Manufacturer> ManufacturerData = new List<Manufacturer>()
        {
            new Manufacturer()
            {
                Id = 1,
                Name = "Audi"
            },
            new Manufacturer()
            {
                Id = 2,
                Name = "Mercedes"
            },
            new Manufacturer()
            {
                Id = 3,
                Name = "BMW"
            },
            new Manufacturer()
            {
                Id = 4,
                Name = "Porsche"
            },
        };

        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 01,
                Model = "C63 W204",
                Type = "Sedan",
                EngineType = "Petrol",
                Horsepower = 457,
                ManufacturerId = 2
            },

            new Car()
            {
                Id = 02,
                Model = "RS6 C8",
                Type = "Avant",
                EngineType = "Petrol",
                Horsepower = 630,
                ManufacturerId = 1
            },

            new Car()
            {
                Id = 03,
                Model = "911 GT3 RS",
                Type = "Coupe",
                EngineType = "Petrol",
                Horsepower = 525,
                ManufacturerId = 4
            },

            new Car()
            {
                Id = 04,
                Model = "i7 M70 xDrive G70 BEV",
                Type = "Sedan",
                EngineType = "Electric",
                Horsepower = 659,
                ManufacturerId = 3
            },

            new Car()
            {
                Id = 04,
                Model = "Q8",
                Type = "SUV",
                EngineType = "Diesel",
                Horsepower = 286,
                ManufacturerId = 1
            },
        };
    }
}
