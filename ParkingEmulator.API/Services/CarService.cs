using ParkingEmulator.Core.Entities;
using ParkingEmulator.Core.Exceptions;
using ParkingEmulator.Core.Interfaces;
using ParkingEmulator.Core.Kernel;
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


        public List<ICar> GetCarsList()//maybe fix
        {
            return parkingInstance.Cars;
        }

        public ICar GetCarDetails(int id)
        {
            return parkingInstance.FindCarById(id);
        }

        public void AddNewCar(decimal startBalance, CarType type)
        {
            try
            {
                parkingInstance.AddCar(new Car(startBalance, type));
            }
            catch (NotEnoughParkingSpaceException ex)
            {
                //implement
            }
        }

        public void RemoveCar(int id)
        {
            try
            {
                parkingInstance.RemoveCar(parkingInstance.FindCarById(id));
            }
            catch (NotExistException ex)
            {
                //implement
            }
            catch (FinedCarException ex)
            {
                //implement
            }
        }
    }
}
