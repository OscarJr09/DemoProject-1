using DemoProject.ViewModels;
using DemoProject.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientDetailsView : ContentPage
    {
        public ClientDetailsView(ClientModel clientDetails)
        {
            InitializeComponent();
            BindingContext = new ClientDetailsViewModel(clientDetails);
        }
    } 
}