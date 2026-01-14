namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsSwitchPage : ContentPage
{
	public ControlsSwitchPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSwitchViewModel();
	}
}