using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParkingEmulator.API.Services;

namespace ParkingEmulator.API.Controllers
{
    //[Produces("application/json")]
    [Route("api/Cars")]
    public class CarsController : ControllerBase
    {
        private readonly CarService carService;

        public CarsController()
        {
            carService = new CarService();
        }

        // GET: api/Cars
        [HttpGet]
        public string GetAllCars()
        {
            return JsonConvert.SerializeObject(carService.GetCarsList());
        }


        //// GET: api/Cars
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Cars
        [HttpPost]
        public void Add([FromBody]string value)
        {

        }
        
        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
