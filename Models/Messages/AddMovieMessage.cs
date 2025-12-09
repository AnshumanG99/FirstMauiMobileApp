using FirstMauiMobileApp.Models.Entities;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.Models.Messages
{
    public class AddMovieMessage : ValueChangedMessage<MarvelMovies>
    {
        public AddMovieMessage(MarvelMovies value) : base(value)  { }

    }
}
