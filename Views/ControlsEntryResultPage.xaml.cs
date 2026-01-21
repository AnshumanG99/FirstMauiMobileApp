namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsEntryResultPage : ContentPage
{
	public ControlsEntryResultPage()
	{
		InitializeComponent();
        BindingContext = new ControlsEntryResultViewModel();

    }
}