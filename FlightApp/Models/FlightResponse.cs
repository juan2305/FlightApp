using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static FlightApp.Models.FlightDatum;


namespace FlightApp.Models
{
    public class FlightResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
