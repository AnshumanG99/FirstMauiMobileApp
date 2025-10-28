using FirstMauiMobileApp.ViewModels;
namespace FirstMauiMobileApp.Views;

public partial class LayoutsStackPage : ContentPage
{
	public LayoutsStackPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsStackViewModel();
    }
}