namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
		BindingContext = new ImagesViewModel();
	}
}