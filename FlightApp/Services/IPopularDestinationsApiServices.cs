using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlightApp.Models;

namespace FlightApp.Services
{
    public interface IPopularDestinationsApiServices
    {
        Task<PopularDestinationsResponse> GetPopularInfoAsync();
    }
}
