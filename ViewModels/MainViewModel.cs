using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Views;
using System.Windows.Input;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title = TitleMain.Title;

        [ObservableProperty]
        public string layouts = TitleMain.Layouts;

        [ObservableProperty]
        public string images = TitleMain.Images;

        [ObservableProperty]
        public string collections = TitleMain.Collections;

        [ObservableProperty]
        public string controls = TitleMain.Controls;

        [ObservableProperty]
        public string sQLite = TitleMain.SQLite;

        //Button Commands
        //public ICommand OnLayoutsClicked { get; set; }

        public MainViewModel() 
        {
            //Title = TitleMain.Title;

            ////Set Commands
            //OnLayoutsClicked = new Command(OnLayoutsClickedAsync);

        }

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }


        [RelayCommand]
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }

        [RelayCommand]
        private async Task CollectionsClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsPage));
        }

        [RelayCommand]
        private async Task ControlsClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsPage));
        }
        //private async void OnLayoutsClickedAsync()
        //{
        //    await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        //}

    }

}
