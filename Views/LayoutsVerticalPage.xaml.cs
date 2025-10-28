using FirstMauiMobileApp.ViewModels;
namespace FirstMauiMobileApp.Views;

public partial class LayoutsVerticalPage : ContentPage
{
	public LayoutsVerticalPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsVerticalViewModel();
	}
}