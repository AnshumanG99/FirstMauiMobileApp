using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ControlsSwitchVMViewModel : ObservableObject
    {
        public string Title => TitleControls.SwitchVMTitle;

        [ObservableProperty]
        private bool isOn;

        [ObservableProperty]
        private Color labelColor;

        public ControlsSwitchVMViewModel()
        {
            isOn = false;
            labelColor = Color.FromRgb(255, 0, 0);
        }

        partial void OnIsOnChanged(bool value) => UpdateVisual(value);

        public void UpdateVisual(bool value)
        {
            LabelColor = value
                ? Color.FromRgb(0, 0, 255)
                : Color.FromRgb(255, 0, 0);
        }
    }
}
