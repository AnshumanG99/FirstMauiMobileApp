using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ControlsStepperVMViewModel : ObservableObject
    {

        public string Title => TitleControls.StepperVMTitle;

        [ObservableProperty]
        public string labelText;

        [ObservableProperty]
        private double direction;

        public ControlsStepperVMViewModel()
        {
            direction = 0;
            LabelText = $"Value of the slider is {direction:F0}";
        }

        partial void OnDirectionChanged(double value) => UpdateVisual(value);

        public void UpdateVisual(double value)
        {
            LabelText = $"Value of the stepper is {value:F0}";

        }
    }
}

