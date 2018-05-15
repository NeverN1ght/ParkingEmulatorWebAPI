using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ParkingEmulator.Core.Entities;
using ParkingEmulator.Core.Kernel;
using ParkingEmulator.Log.Logging;

namespace ParkingEmulator.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parking = Parking.Instance;
            TransactionLogger.LogInit();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
