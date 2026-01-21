using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    [QueryProperty(nameof(EntryText), "entryText")]
    public partial class ControlsEntryResultViewModel : ObservableObject
    {
        public string Title => TitleControls.EntryResultTitle;

        [ObservableProperty]
        private string entryText;
    }
}
