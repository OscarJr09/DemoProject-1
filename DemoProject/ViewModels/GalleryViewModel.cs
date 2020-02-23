using DemoProject.Models;
using DemoProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoProject.ViewModels
{
    public class GalleryViewModel : BaseViewModel
    {
        private GalleryModel _gallery { get; set; }

        private ObservableCollection<Image> _imageList;
        public ObservableCollection<Image> ImageList 
        {
            get => _imageList;
            set => SetProperty(ref _imageList, value, "ImageList");
        }

        public GalleryViewModel()
        {
            try
            {
                var svc = new HttpService();
                _gallery = svc.GetGalleryModels();
                ImageList = new ObservableCollection<Image>(_gallery.Data.Images);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
