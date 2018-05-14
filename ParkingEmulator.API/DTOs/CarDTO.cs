using ParkingEmulator.Core.Entities;

namespace ParkingEmulator.API.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public CarType Type { get; set; }
    }
}
