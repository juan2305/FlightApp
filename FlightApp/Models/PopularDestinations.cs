using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Models
{
    public class PopularDestinations
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("airline")]
        public string Airline { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("departure_at")]
        public DateTime DepartureAt { get; set; }

        [JsonProperty("return_at")]
        public DateTime ReturnAt { get; set; }

        [JsonProperty("transfers")]
        public int Transfers { get; set; }

        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }
    }
}
