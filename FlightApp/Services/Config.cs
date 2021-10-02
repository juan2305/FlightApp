using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FlightApp.Services
{
    public class Config
    {
         const string ApiAccessKey = "54584c8325755dc2dbad7aadad6df16a";
        public static string ApiUrl = "https://api.travelpayouts.com/v2/prices/latest?currency=usd&period_type=year&page=1&limit=30&show_to_affiliates=true&sorting=price&trip_class=0&token={ApiAccessKey}";
        // private const string ApiAccessKey = "YOUR ACCESS KEY";
    }
}
