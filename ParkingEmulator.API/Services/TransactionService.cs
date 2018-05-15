using ParkingEmulator.Core.Entities;
using ParkingEmulator.Core.Interfaces;
using ParkingEmulator.Core.Kernel;
using ParkingEmulator.Log.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingEmulator.API.Services
{
    public class TransactionService
    {
        private readonly Parking parkingInstance;

        public TransactionService()
        {
            parkingInstance = Parking.Instance;
        }

        //----

        public List<string> GetTransactionLog()
        {
            return TransactionLogger.ReadTransactionLog();
        }

        public List<ITransaction> GetLastMinuteTransactions()
        {
            return parkingInstance.GetLastMinuteTransactions();
        }

        public IEnumerable<ITransaction> GetLastMinuteTransactionsById(int id)
        {
            return parkingInstance.GetLastMinuteTransactions().Where(c => c.CarId == id);
        }

        public void AddCarBalance(int id, decimal funds)
        {
            parkingInstance.AddBalance(id, funds);
        }
    }
}
