namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;
public partial class ImagesURIPage : ContentPage
{
	public ImagesURIPage()
	{
		InitializeComponent();
		BindingContext = new ImagesURIViewModel();
	}
}