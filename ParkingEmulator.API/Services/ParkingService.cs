using ParkingEmulator.Core.Kernel;

namespace ParkingEmulator.API.Services
{
    public class ParkingService
    {
        private readonly Parking parkingInstance;

        public ParkingService()
        {
            parkingInstance = Parking.Instance;
        }

        //----

        public uint GetFreePlaces()
        {
            return parkingInstance.GetFreeParkingPlaces();
        }

        public int GetOcuppiedPlaces()
        {
            return parkingInstance.Cars.Count;
        }

        public decimal GetEarnedBalance()
        {
            return parkingInstance.EarnedBalance;
        }
    }
}
