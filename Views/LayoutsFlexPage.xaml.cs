namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class LayoutsFlexPage : ContentPage
{
	public LayoutsFlexPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsFlexViewModel();
	}
}