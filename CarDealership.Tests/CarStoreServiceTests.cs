using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.BL.Services;
using CarDealership.DL.Interfaces;
using CarDealership.DL.Repositories;
using CarDealership.Models.Models;
using CarDealership.Models.Requests;
using Moq;

namespace CarDealership.Tests
{
    public class CarStoreServiceTests
    {
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

        [Fact]
        public void CheckCarCount_OK()
        {
            // setup
            var input = 10;
            var expectedCount = 18;

            var mockedCarRepository = new Mock<ICarRepository>();
            mockedCarRepository.Setup(x => x.GetAll()).Returns(CarData);

            // inject
            var carService = new CarService(mockedCarRepository.Object);
            var manufacturerService = new ManufacturerService(new ManufacturerRepository());
            var service = new CarStoreService(manufacturerService, carService);

            // Act
            var result = service.GetAllCarsCount(input);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CheckCarCount_NegativeInput()
        {
            // setup
            var input = -8;
            var expectedCount = 0;

            var mockedCarRepository = new Mock<ICarRepository>();
            mockedCarRepository.Setup(x => x.GetAll()).Returns(CarData);

            // inject
            var carService = new CarService(mockedCarRepository.Object);
            var manufacturerService = new ManufacturerService(new ManufacturerRepository());
            var service = new CarStoreService(manufacturerService, carService);

            // Act
            var result = service.GetAllCarsCount(input);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]

        public void GetAllCarsByManufacturer_OK()
        {
            // setup
            var request = new GetAllCarsByManufacturerRequest
            {
                ManufacturerId = 4
            };
            var expectedCount = 3;

            var mockedCarRepository = new Mock<ICarRepository>();
            var mockedManufacturerRepository = new Mock<IManufacturerRepository>();

            mockedCarRepository.Setup(x => x.GetAllCarsByManufacturer(request.ManufacturerId))
                .Returns(CarData
                .Where(c => c.ManufacturerId == request.ManufacturerId)
                .ToList());

            mockedManufacturerRepository.Setup(x => x.GetById(request.ManufacturerId))
                .Returns(ManufacturerData!
                .FirstOrDefault(m => m.Id == request.ManufacturerId)!);

            // inject

            var carService = new CarService(mockedCarRepository.Object);
            var manufacturerService = new ManufacturerService(mockedManufacturerRepository.Object);
            var service = new CarStoreService(manufacturerService, carService);

            // Act
            var result = service.GetAllCarsByManufacturer(request);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result!.Cars.Count);
            Assert.Equal(request.ManufacturerId, result.Manufacturer.Id);  
        }
    }
}
