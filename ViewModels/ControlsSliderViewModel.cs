using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ControlsSliderViewModel : ObservableObject
    {
        public string Title => TitleCollections.CollectionsTitle;

        [ObservableProperty]
        private double sliderValue;

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.5;
        }   
    }
}
