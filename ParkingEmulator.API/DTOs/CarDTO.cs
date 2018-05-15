using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ParkingEmulator.Core.Entities;

namespace ParkingEmulator.API.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        [JsonProperty("error")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CarType Type { get; set; }
    }
}
