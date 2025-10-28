namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class LayoutsAbsolutePage : ContentPage
{
	public LayoutsAbsolutePage()
	{
		InitializeComponent();
		BindingContext = new LayoutsAbsoluteViewModel();

    }
}