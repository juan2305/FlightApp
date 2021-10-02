using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FlightApp.Models;
using FlightApp.Services;
using Newtonsoft.Json;

namespace FlightApp.Services
{
        public class FlightApiServices : IFlightApiServices
        {
        const string ApiAccessKey = "54584c8325755dc2dbad7aadad6df16a";
        public async Task<FlightResponse> GetFlightInfoAsync()
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync($"https://api.travelpayouts.com/v2/prices/latest?currency=usd&period_type=year&page=1&limit=30&show_to_affiliates=true&sorting=price&trip_class=0&token=" + ApiAccessKey);

            if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var flightResponse = JsonConvert.DeserializeObject<FlightResponse>(responseString);
                    return flightResponse;
                }
                return null;
            }
        }
}
