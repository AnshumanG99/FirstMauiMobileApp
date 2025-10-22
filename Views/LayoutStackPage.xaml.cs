using FirstMauiMobileApp.ViewModels;

namespace FirstMauiMobileApp.Views;

public partial class LayoutStackPage : ContentPage
{
	public LayoutStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutStackViewModel();
	}
}