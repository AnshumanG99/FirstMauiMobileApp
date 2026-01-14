namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsSwitchVMPage : ContentPage
{
	public ControlsSwitchVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSwitchVMViewModel();
	}
}