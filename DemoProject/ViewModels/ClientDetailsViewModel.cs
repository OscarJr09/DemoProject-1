using DemoProject.Models;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoProject.ViewModels
{
    public class ClientDetailsViewModel : BaseViewModel
    {
        private double latitude;
        private double longitude;

        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }

        public ICommand ViewLocation => new Command(() =>
        {
            Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = Address,
                NavigationMode = NavigationMode.None
            });
        });

        public ClientDetailsViewModel(ClientModel clientDetails)
        {
            Name = clientDetails.Name;
            Mobile = clientDetails.Phone;
            Email = clientDetails.Email;
            Website = clientDetails.Website;
            Company = clientDetails.Company.Name;
            Address = clientDetails.Address.Suite + " " + clientDetails.Address.Street + ", " + clientDetails.Address.City + " " + clientDetails.Address.Zipcode;
            latitude = Convert.ToDouble(clientDetails.Address.Geo.Lat);
            longitude = Convert.ToDouble(clientDetails.Address.Geo.Lng);
        }
    }
}
