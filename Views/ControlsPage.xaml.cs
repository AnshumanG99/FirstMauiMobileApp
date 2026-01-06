namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.Models;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
		BindingContext = new ControlsViewModel();
	}
}