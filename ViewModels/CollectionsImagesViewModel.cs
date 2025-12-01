using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Entities;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class CollectionsImagesViewModel : ObservableObject
    {
        private List<MarvelCharacters> _marvelcharacters;
        public string Title => TitleCollectionsImages.Title;
        public ObservableCollection<MarvelCharacters> MarvelCharactersCollection { get; } = new();

        public CollectionsImagesViewModel()
        {
            _marvelcharacters = MarvelCharacters.GetCharacters();
            LoadCharacters();
        }

        private void LoadCharacters()
        {
            try
            {
                MarvelCharactersCollection.Clear();
                foreach (var p in _marvelcharacters)
                {
                    MarvelCharactersCollection.Add(new MarvelCharacters { CharacterName = p.CharacterName, ActorName = p.ActorName, ImagePath = p.ImagePath});
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
