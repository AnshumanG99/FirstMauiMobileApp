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
    public partial class ControlsEntryViewModel : ObservableObject
    {
        public string Title => TitleControls.StepperMenuTitle;
        public string EntryXAML => TitleControls.StepperXAML;
        public string EntryVM => TitleControls.StepperVM;

        [RelayCommand]
        private async Task EntryXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryXAMLPage));
        }

        [RelayCommand]
        private async Task EntryVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryVMPage));
        }

    }
}
