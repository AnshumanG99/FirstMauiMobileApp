using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ControlsSliderVMViewModel : ObservableObject
    {
        public string Title => TitleControlsSliderVM.Title;
        public string BoxColor => TitleControlsSliderVM.BoxColor;
        public string IncreaseColor => TitleControlsSliderVM.IncreaseColor;
        public string DecreaseColor => TitleControlsSliderVM.DecreaseColor;
        public string LabelColor => TitleControlsSliderVM.LabelColor;


        [ObservableProperty]
        public string labelText;

        [ObservableProperty]
        private double sliderValue;

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.5;
            LabelText = $"Value of the slider is {SliderValue:F2}";
        }

        public ControlsSliderVMViewModel()
        {
            SliderValue = 1;
            LabelText = $"Value of the slider is {SliderValue:F2}";
        }

        partial void OnSliderValueChanged(double value) => UpdateVisual(value);

        public void UpdateVisual(double value)
        {
            LabelText = $"Value of the slider is {value:F2}";
        }
    }
}
