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
    public partial class CollectionsViewModel : ObservableObject
    {
        public string Title => TitleCollections.CollectionsTitle;
        public string Collections => TitleCollections.Collections;
        public string Images => TitleCollections.Images;
        public string Buttons => TitleCollections.Buttons;
        public string Icons => TitleCollections.Icons;

        [RelayCommand]
        private async Task CollectionsClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsMarvelMoviesPage));
        }

        [RelayCommand]
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsImagesPage));
        }

        [RelayCommand]
        private async Task ButtonsClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsButtonsPage));
        }

        [RelayCommand]
        private async Task IconsClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsIconsPage));
        }

    }
}
