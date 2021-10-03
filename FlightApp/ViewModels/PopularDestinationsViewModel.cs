using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FlightApp.Services;
using Xamarin.Forms;
using FlightApp.Models;

namespace FlightApp.ViewModels
{
    public class PopularDestinationsViewModel : BaseViewModel
    {
        public string Origin { get; set; }// IATA city code - from 2 to 3 symbols 
        public string Destination { get; set; }
        public int Price { get; set; }// Price in RUB(Russian Ruble)
        public string Airline { get; set; }
        public int FlightNumber { get; set; }
        public DateTime DepartureAt { get; set; }
        public DateTime ReturnAt { get; set; }
        public int Transfers { get; set; }// Numbers of scales
        public DateTime ExpiresAt { get; set; }
        public List<PopularDestinations> PopularData { get; set; }
        public ICommand DeployPopularDataCommand { get; set; }

        public PopularDestinationsViewModel()
        {
            // _popularDestinationsApi = new PopularDestinationsApiServices(); dando problemas con el PopularDestinationsApiServices
            DeployPopularDataCommand = new Command(OnDeploy);
        }

        private async void OnDeploy()
        {
            var popularResponse = await _popularDestinationsApi.GetPopularInfoAsync();
            this.PopularData = popularResponse.PopularData;
        }
        
        IPopularDestinationsApiServices _popularDestinationsApi;
    }
}
