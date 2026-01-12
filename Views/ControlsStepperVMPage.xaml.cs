namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsStepperVMPage : ContentPage
{
	public ControlsStepperVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsStepperVMViewModel();
	}
}