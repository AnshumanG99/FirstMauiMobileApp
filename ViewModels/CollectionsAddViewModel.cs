using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Models.Entities;
using FirstMauiMobileApp.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class CollectionsAddViewModel : ObservableObject
    {

        public string Title = TitleCollectionsButtons.AddTitle;

        [ObservableProperty]
        private string movieName = string.Empty;

        [RelayCommand]
        private async Task SaveClicked()
        {
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                await Shell.Current.DisplayAlert(Title, Msgs.NotEmpty, "Ok");
                return;
            }

            var movie = new MarvelMovies { NameofMovie = MovieName };

            WeakReferenceMessenger.Default.Send(new AddMovieMessage(movie));

            await Shell.Current.GoToAsync("..");
        }

    }
}
