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
    public class PopularDestinationsApiServices //: IPopularDestinationsApiServices causando errores con la implementacion de interface
    {
        public async Task<PopularDestinationsResponse> GetPopularDestinationsInfoAsync()
        {
            HttpClient httpClientPopularDestinations = new HttpClient();
            var responsePopularDestination = await httpClientPopularDestinations.GetAsync(Config.PopularDestinationsUrl);

            if (responsePopularDestination.IsSuccessStatusCode)
            {
                var responseStringPopular = await responsePopularDestination.Content.ReadAsStringAsync();
                var popularResponse = JsonConvert.DeserializeObject<PopularDestinationsResponse>(responseStringPopular);
                return popularResponse;
            }
            return null;
        }
    }
}
