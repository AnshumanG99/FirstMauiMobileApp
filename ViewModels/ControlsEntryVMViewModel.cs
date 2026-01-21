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
    public partial class ControlsEntryVMViewModel : ObservableObject
    {
        public string Title => TitleControls.EntryVMTitle;

        [ObservableProperty]
        private string entryText;

        [RelayCommand]
        private async Task EntryClicked()
        {
            if (string.IsNullOrWhiteSpace(EntryText))
            {
                await Shell.Current.DisplayAlert(TitleControls.EntryXAMLTitle, "Entry is empty. Please enter text.", "OK");
            }
            else
            {
                await Shell.Current.GoToAsync($"{nameof(ControlsEntryResultPage)}?entryText={EntryText}");
            }
        }
    }
}
