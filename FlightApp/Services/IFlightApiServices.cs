using FlightApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Services
{
    public interface IFlightApiServices
    {
        Task<FlightResponse> GetFlightInfoAsync();
    }
}
