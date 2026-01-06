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
    public partial class ControlsViewModel : ObservableObject
    {
        public string Title => TitleControls.Title;
        public string Slider => TitleControls.Slider;
        public string Switch => TitleControls.Switch;
        public string Stepper => TitleControls.Stepper;
        public string Entry => TitleControls.Entry;
        public string Picker => TitleControls.Picker;
        public string DateandTimePicker => TitleControls.DateandTimePicker;

        [RelayCommand]
        private async Task SliderClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderPage));
        }

        [RelayCommand]
        private async Task SwitchClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSwitchPage));
        }

        [RelayCommand]
        private async Task StepperClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperPage));
        }

        [RelayCommand]
        private async Task EntryClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryPage));
        }
        [RelayCommand]
        private async Task PickerClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsPickerPage));
        }
        [RelayCommand]
        private async Task DateandTimePickerClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsDateandTimePage));
        }
    }
}
