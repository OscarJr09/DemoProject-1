using DemoProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientView : ContentPage
    {
        public ClientView()
        {
            InitializeComponent();
            BindingContext = new ClientViewModel();
        }
    }
}