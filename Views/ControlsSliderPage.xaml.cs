namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsSliderPage : ContentPage
{
	public ControlsSliderPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderViewModel();
    }
}