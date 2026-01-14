namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsEntryPage : ContentPage
{
	public ControlsEntryPage()
	{
		InitializeComponent();
		BindingContext = new ControlsEntryViewModel();
    }
}