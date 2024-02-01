using CarDealership.Models.Requests;
using CarDealership.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.BL.Interfaces
{
    public interface ICarStoreService
    {
        public GetAllCarsByManufacturerResponse
            GetAllCarsByManufacturer(GetAllCarsByManufacturerRequest request);

            int GetAllCarsByCount(int inputCount);
            }
}
