using DemoProject.Helpers;
using DemoProject.Models;
using DemoProject.Services;
using DemoProject.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoProject.ViewModels
{
    public class ClientViewModel : BaseViewModel
    {
        private ObservableCollection<ClientModel> _clientList;
        private ObservableCollection<ClientModel> _clientListHistory { get; set; }
        public ObservableCollection<ClientModel> ClientList
        {
            get => _clientList;
            set => SetProperty(ref _clientList, value, "ClientList");
        }

        private string _searchText;
        public string SearchText 
        {
            get => _searchText;
            set 
            {
                SetProperty(ref _searchText, value, "SearchText");
                onSearchTextChanged();
            }
        }

        private ClientModel _selectedClient;
        public ClientModel SelectedClient
        {
            get => _selectedClient;
            set => SetProperty(ref _selectedClient, value, "SelectedClient");
        }

        public ClientViewModel()
        {
            getClientAsync();
        }

        public ICommand SelectedClientCommand => new Command(async () =>
        {
            var selectedClient = new ClientDetailsView(SelectedClient);
            await NavigationHelper.PushAsync(selectedClient);
        });

        private void onSearchTextChanged()
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(SearchText))
                    ClientList = _clientListHistory;                   
                else
                    ClientList = new ObservableCollection<ClientModel>(ClientList.Where(x => x.Name.ToLower().Contains(SearchText.ToLower())));
                    
            }
            catch(Exception ex)
            {

            }
        }

        private async void getClientAsync()
        {
            try
            {
                var svc = new HttpService();
                ClientList = new ObservableCollection<ClientModel>(await svc.GetClientsAsync());
                _clientListHistory = ClientList;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
