using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FlightApp.Services
{
    public class Config
    {
        private const string apiAccessKey = "54584c8325755dc2dbad7aadad6df16a";
        public static string FlightUrl = $"https://api.travelpayouts.com/v2/prices/latest?currency=usd&period_type=year&page=1&limit=30&show_to_affiliates=true&sorting=price&trip_class=0&token={apiAccessKey}";
        public static string PopularDestinationsUrl = $"http://api.travelpayouts.com/v1/city-directions?origin=JFK&cy=&token={apiAccessKey}";
        // private const string ApiAccessKey = "YOUR ACCESS KEY";
    }
}
