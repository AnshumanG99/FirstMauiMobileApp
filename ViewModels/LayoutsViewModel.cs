using FirstMauiMobileApp.Models.Titles;
using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class LayoutsViewModel : ObservableObject
    {

        [ObservableProperty]
        public string layoutsTitle = TitleLayouts.LayoutsTitle;

        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayout;

        [ObservableProperty]
        public string absoluteLayout = TitleLayouts.AbsoluteLayout;

        [ObservableProperty]
        public string verticalStack = TitleLayouts.VerticalStack;

        [ObservableProperty]
        public string horizontalStack = TitleLayouts.HorizontalStack;

        [ObservableProperty]
        public string flexLayout = TitleLayouts.FlexLayout;

        public LayoutsViewModel()
        {
            //Title = TitleLayouts.LayoutsTitle;
        }
        
        [RelayCommand]
        private async Task StackLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutStackPage));
        }
    }
}
