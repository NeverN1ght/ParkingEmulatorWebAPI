using System;
using Microsoft.AspNetCore.Mvc;
using ParkingEmulator.API.Services;

namespace ParkingEmulator.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Transactions")]
    public class TransactionsController : Controller
    {
        private readonly TransactionService transactionService;

        public TransactionsController()
        {
            transactionService = new TransactionService();
        }


        // GET: api/Transactions/All
        [HttpGet("All")]
        public IActionResult GetTransactionLog()
        {
            return Ok(transactionService.GetTransactionLog());
        }

        // GET: api/Transactions/LastMinute
        [HttpGet("LastMinute")]
        public IActionResult GetLastMinuteTransactions()
        {
            return Ok(transactionService.GetLastMinuteTransactions());
        }

        // GET: api/Transactions/LastMinute/{id}
        [HttpGet("LastMinute/{id}")]
        public IActionResult GetLastMinuteById(int id)
        {
            try
            {
                return Ok(transactionService.GetLastMinuteTransactionsById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        // PUT: api/Transactions/Add
        [HttpPut("Add/{id}")]
        public IActionResult AddBalance(int id, [FromBody]decimal value)
        {
            try
            {
                transactionService.AddCarBalance(id, value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
