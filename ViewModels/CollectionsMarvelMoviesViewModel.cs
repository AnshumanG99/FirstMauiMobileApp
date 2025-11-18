using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class CollectionsMarvelMoviesViewModel : ObservableObject
    {
        private List<MarvelMovies> _marvelmovies;
        public string Title => TitleCollectionsMarvelMovies.MarvelMoviesTitle;

        //= new() -> constructs an empty ObservableCollection<MarvelMovies>
        //and assigns it to the property — using the target-typed new() shorthand.
        //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
        //  new ObservableCollection<MarvelMovies>();
        public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

        public CollectionsMarvelMoviesViewModel()
        {
            _marvelmovies = MarvelMovies.GetMovies();
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                MarvelMoviesCollection.Clear();
                foreach (var p in _marvelmovies)
                {
                    MarvelMoviesCollection.Add(new MarvelMovies { NameofMovie = p.NameofMovie });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}
