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
        //private string StackLayout { get; set; } = TitleLayouts.StackLayout;
        //private string VerticalStack { get; set; } = TitleLayouts.VerticalStack;
        //private string HorizontalStack { get; set; } = TitleLayouts.HorizontalStack;
        //private string AbsoluteLayout { get; set; } = TitleLayouts.AbsoluteLayout;
        //private string FlexLayout { get; set; } = TitleLayouts.FlexLayout;

        [ObservableProperty]
        public string title = TitleLayouts.LayoutsTitle;
        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayout;
        [ObservableProperty]
        public string absoluteLayout = TitleLayouts.AbsoluteLayout;
        [ObservableProperty]
        public string verticalStack = TitleLayouts.VerticalStack;
        [ObservableProperty]
        public string horizontalStack = TitleLayouts.HorizontalStack;

        [RelayCommand]
        private async Task StackLayoutClicked()
        {
            //await Shell.Current.GoToAsync(nameof(LayoutsStackPage));
        }

        public LayoutsViewModel()
        {
            //Title = TitleLayouts.LayoutsTitle;
        }
    }
}
