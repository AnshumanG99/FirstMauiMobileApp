using FirstMauiMobileApp.ViewModels;

namespace FirstMauiMobileApp.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsViewModel();
	}
}