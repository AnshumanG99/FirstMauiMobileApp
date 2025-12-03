using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Entities;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class CollectionsUpdateableViewModel : ContentPage
    {

        public string ButtonsTitle = TitleCollections.Buttons;
        public string IconsTitle = TitleCollections.Icons;

        [ObservableProperty] private bool isBusy;

        [ObservableProperty] 
        private ObservableCollection<MarvelMovies> movieCollection = new();

        public CollectionsUpdateableViewModel(CollectionsUpdateableViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        public CollectionsUpdateableViewModel()
        {
            WeakReferenceMessenger.Default.Register<UpdateMovieMessage>(this, (r, m) =>
            {
                var oldTitle = m.OldValue.NameofMovie; 
                var idx = MovieCollection.ToList().FindIndex(x => x.NameofMovie == oldTitle);
                if (idx >= 0)
                    MovieCollection[idx] = m.NewValue;

            });
        }
    }
}
