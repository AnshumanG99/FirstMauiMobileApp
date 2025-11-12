using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ImagesViewModel
    {
        public string Images => TitleImages.ImagesTitle;
        public string Embedded => TitleImages.EmbeddedTitle;
        public string ActivityIndicator => TitleImages.ActivityIndicatorTitle;
        public string URI => TitleImages.URITitle;


        [RelayCommand]
        private async Task EmbeddedClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityIndicatorClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesActivityIndicatorPage));
        }

        [RelayCommand]
        private async Task URIClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }

    }
}
