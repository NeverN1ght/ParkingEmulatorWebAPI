using Microsoft.AspNetCore.Mvc;
using ParkingEmulator.API.Services;

namespace ParkingEmulator.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Parking")]
    public class ParkingController : Controller
    {
        private readonly ParkingService parkingService;

        public ParkingController()
        {
            parkingService = new ParkingService();
        }

        // GET: api/Parking/Free
        [HttpGet("Free")]
        public IActionResult GetFreePlaces()
        {
            return Ok(parkingService.GetFreePlaces());
        }

        // GET: api/Parking/Occupied
        [HttpGet("Occupied")]
        public IActionResult GetOccupiedPlaces()
        {
            return Ok(parkingService.GetOcuppiedPlaces());
        }

        // GET: api/Parking/Earned
        [HttpGet("Earned")]
        public IActionResult GetEarnedBalance()
        {
            return Ok(parkingService.GetEarnedBalance());
        }
    }
}
