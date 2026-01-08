namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.Models;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsStepperPage : ContentPage
{
	public ControlsStepperPage()
	{
		InitializeComponent();
		BindingContext = new ControlsStepperViewModel();
	}
}