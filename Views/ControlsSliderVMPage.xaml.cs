namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsSliderVMPage : ContentPage
{
	public ControlsSliderVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderVMViewModel();
    }
}