using ParkingEmulator.API.DTOs;
using ParkingEmulator.Core.Entities;
using ParkingEmulator.Core.Interfaces;
using ParkingEmulator.Core.Kernel;
using System;
using System.Collections.Generic;

namespace ParkingEmulator.API.Services
{
    public class CarService
    {
        private readonly Parking parkingInstance;

        public CarService()
        {
            parkingInstance = Parking.Instance;
        }

        //----

        public List<ICar> GetCarsList()
        {
            return parkingInstance.Cars;
        }

        public ICar GetCarDetails(int id)
        {
            return parkingInstance.FindCarById(id);
        }

        public int AddNewCar(CarDTO carDTO)
        {
            if (carDTO == null)
                throw new NullReferenceException("No data!");

            if (carDTO.Balance <= 0)
                throw new ArgumentException("Balance must be more than 0!");

            if (carDTO.Type < 0 || (int)carDTO.Type > 3)
                throw new ArgumentException("Wrong car type!");

            return parkingInstance.AddCar(new Car(carDTO.Balance, carDTO.Type));
        }

        public void RemoveCar(int id)
        {
            parkingInstance.RemoveCar(parkingInstance.FindCarById(id));
        }
    }
}
