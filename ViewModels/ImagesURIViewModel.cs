using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ImagesURIViewModel : ObservableObject
    {
        public string Title => TitleImagesURI.URIImagesTitle;

        [ObservableProperty]
        private ImageSource imageSourceUrl;

        public ImagesURIViewModel()
        {
            ImageSourceUrl = new UriImageSource
            {
                Uri = new Uri(TitleImagesURI.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }

    }
}
