using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.Models.Entities
{
    public class MarvelCharacters
    {
        public string CharacterName { get; set; }
        public string ActorName { get; set; }
        public ImageSource ImagePath { get; set; }

        //Image Buttons
        //public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        //public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

        public MarvelCharacters()
        {

        }

        public MarvelCharacters(string name, string actor, ImageSource image)
        {
            CharacterName = name;
            ActorName = actor;
            ImagePath = image;
        }

        public static List<MarvelCharacters> GetCharacters() => new List<MarvelCharacters>
    {
        new MarvelCharacters("Starlord", "Chris Pratt", "drakemaye.png"),
        //new MarvelCharacters("Gamora", "Zoe Saldana", "gamora.jpg"),
        //new MarvelCharacters("Groot", "Vin Diesel", "groot.jpg"),
        //new MarvelCharacters("Rocket", "Bradley Cooper", "rocket.jpg"),
        //new MarvelCharacters("Nebula", "Karen Gillan", "nebula.jpg")

     };
    }
}
