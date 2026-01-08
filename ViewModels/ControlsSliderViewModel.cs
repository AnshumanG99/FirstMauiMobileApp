using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ControlsSliderViewModel : ObservableObject
    {
        public string Title => TitleControlsSlider.Title;
        public string SliderXAML => TitleControlsSlider.SliderXAML;
        public string SliderVM => TitleControlsSlider.SliderVM;

        [RelayCommand]
        private async Task SliderXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderXAMLPage));
        }

        [RelayCommand]
        private async Task SliderVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderVMPage));
        }

    }
}
