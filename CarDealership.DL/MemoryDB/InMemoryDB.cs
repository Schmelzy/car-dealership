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
                Name = "Porsche"
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
                Name = "Audi"
            },
        };

        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 101,
                Model = "C63 W204",
                Type = "Sedan",
                EngineType = "Petrol",
                Horsepower = 457,
                ManufacturerId = 2
            },

            new Car()
            {
                Id = 102,
                Model = "RS6 C8",
                Type = "Avant",
                EngineType = "Petrol",
                Horsepower = 630,
                ManufacturerId = 4
            },

            new Car()
            {
                Id = 103,
                Model = "911 GT3 RS",
                Type = "Coupe",
                EngineType = "Petrol",
                Horsepower = 525,
                ManufacturerId = 1
            },

            new Car()
            {
                Id = 104,
                Model = "i7 M70 xDrive G70 BEV",
                Type = "Sedan",
                EngineType = "Electric",
                Horsepower = 659,
                ManufacturerId = 3
            },

            new Car()
            {
                Id = 105,
                Model = "Q8",
                Type = "SUV",
                EngineType = "Diesel",
                Horsepower = 286,
                ManufacturerId = 4
            },

             new Car()
            {
                Id = 106,
                Model = "M5 CS",
                Type = "Sedan",
                EngineType = "Petrol",
                Horsepower = 627,
                ManufacturerId = 3
            },

              new Car()
            {
                Id = 107,
                Model = "R8 V10",
                Type = "Coupe",
                EngineType = "Petrol",
                Horsepower = 620,
                ManufacturerId = 4
            },

               new Car()
            {
                Id = 108,
                Model = "E220d W213",
                Type = "Cabriolet",
                EngineType = "Diesel",
                Horsepower = 194,
                ManufacturerId = 2
            },
        };
    }
}
