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
           
            public async Task<FlightResponse> GetFlightInfoAsync()
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync(Config.ApiUrl);

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
