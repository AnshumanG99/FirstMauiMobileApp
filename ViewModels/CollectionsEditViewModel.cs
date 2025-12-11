using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstMauiMobileApp.Models.Messages;

namespace FirstMauiMobileApp.ViewModels
{
    [QueryProperty(nameof(MovieName), "movieName")]
    public partial class CollectionsEditViewModel : ObservableObject
    {

        private string _originalMovieName;

        public string Title => TitleCollectionsButtons.EditTitle;

        [ObservableProperty]
        private string movieName;

        partial void OnMovieNameChanged(string value)
        {
            if (_originalMovieName is null)
            {
                _originalMovieName = value;
            }
        }

        [RelayCommand]
        private async Task UpdateClicked()
        {
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                await Shell.Current.DisplayAlert(Title, Msgs.NotEmptyMovie, "OK");
                return;
            }

            var oldMovie = new MarvelMovies(_originalMovieName);
            var newMovie = new MarvelMovies(MovieName);

            WeakReferenceMessenger.Default.Send(new UpdateMovieMessage(oldMovie, newMovie));
            await Shell.Current.GoToAsync("..");
        }

    }
}
