using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParkingEmulator.API.DTOs;
using ParkingEmulator.API.Services;
using ParkingEmulator.Core.Exceptions;
using ParkingEmulator.Core.Interfaces;
using ParkingEmulator.Core.Entities;

namespace ParkingEmulator.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Cars")]
    public class CarsController : ControllerBase
    {
        private readonly CarService carService;

        public CarsController()
        {
            carService = new CarService();
        }



        // GET: api/Cars/Get
        [HttpGet("Get")]
        public List<ICar> GetAllCars()
        {
            return carService.GetCarsList();
        }

        // GET: api/Cars/Get/{id}
        [HttpGet("Get/{id}")]
        public IActionResult GetCarById(int id)
        {
            try
            {
                return Ok(carService.GetCarDetails(id));
            }
            catch (NotExistException ex)
            {
                return NotFound(ex.Message);
            }
        }
        
        // POST: api/Cars/Add
        [HttpPost("Add")]
        public IActionResult AddCar([FromBody]CarDTO carDTO)
        {
            try
            {
                var carId = carService.AddNewCar(carDTO);

                return CreatedAtAction("GetCarById", 
                    new { Id =  carId}, 
                        carService.GetCarDetails(carId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }       
        
        // DELETE: api/Cars/Delete/{id}
        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteCar(int id)
        {
            try
            {
                carService.RemoveCar(id);
                return NoContent();
            }
            catch (NotExistException ex)
            {
                return NotFound(ex.Message);
            }
            catch (FinedCarException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
