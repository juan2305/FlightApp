using FlightApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static FlightApp.Models.FlightDatum;

namespace FlightApp.ViewModels
{
    public class FlightViewModel : BaseViewModel
    {
        public string Value { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Gate { get; set; }
        public string Distance { get; set; }
        public ICommand DeployDataCommand { get; set; }
        public List<Datum> Data { get; set; }

        public FlightViewModel()
        {
            _flightApiService = new FlightApiServices();
            DeployDataCommand = new Command(OnDeploy);
        }

        private async void OnDeploy()
        {
            var flightResponse = await _flightApiService.GetFlightInfoAsync();
            this.Data = flightResponse.Data;
        }
        IFlightApiServices _flightApiService;
    }
}
