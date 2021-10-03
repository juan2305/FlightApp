using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Models
{
    public class PopularDestinationsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<PopularDestinations> PopularData { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
