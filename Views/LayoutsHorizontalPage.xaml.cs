namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class LayoutsHorizontalPage : ContentPage
{
	public LayoutsHorizontalPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsHorizontalViewModel();
	}
}