using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;
using Microsoft.Maui.Controls;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ImagesEmbeddedViewModel : ObservableObject
    {
        public string Title => TitleImagesEmbedded.EmbeddedImageTitle;

        public ImageSource ImageSource => "drakemaye.png";
    }
}
