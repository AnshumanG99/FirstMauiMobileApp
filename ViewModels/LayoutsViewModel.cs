using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    class LayoutsViewModel : BaseViewModel
    {
        public string StackLayout { get; set; } = TitleLayouts.StackLayout;
        public string VerticalStack { get; set; } = TitleLayouts.VerticalStack;
        public string HorizontalStack { get; set; } = TitleLayouts.HorizontalStack;
        public string AbsoluteLayout { get; set; } = TitleLayouts.AbsoluteLayout;

        public LayoutsViewModel()
        {
            Title = TitleLayouts.LayoutsTitle;
        }
    }
}
