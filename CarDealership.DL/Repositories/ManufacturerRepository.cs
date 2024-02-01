using CarDealership.DL.Interfaces;
using CarDealership.DL.MemoryDB;
using CarDealership.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DL.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        public void Add(Manufacturer manufacturer)
        {
            InMemoryDB.ManufacturerData.Add(manufacturer);
        }

        public void Delete(int id)
        {
            var manufacturer = GetById(id);
            if (manufacturer != null)
            {
                InMemoryDB.ManufacturerData.Remove(manufacturer);
            }
        }

        public List<Manufacturer> GetAll()
        {
            return InMemoryDB.ManufacturerData;
        }

        public Manufacturer GetById(int id)
        {
            return InMemoryDB.ManufacturerData.FirstOrDefault(m => m.Id == id);
        }
    }
}
