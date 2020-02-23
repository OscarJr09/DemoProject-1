using DemoProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryView : ContentPage
    {
        public GalleryView()
        {
            InitializeComponent();
            BindingContext = new GalleryViewModel();
        }
    }
}