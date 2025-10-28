using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class LayoutsVerticalViewModel : ObservableObject
    {
        [ObservableProperty]
        public string verticalStackLayoutTitle = TitleLayoutsVerticalStack.VerticalLayoutTitle;

    }
}
