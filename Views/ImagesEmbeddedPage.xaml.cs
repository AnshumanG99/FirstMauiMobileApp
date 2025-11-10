namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ImagesEmbeddedPage : ContentPage
{
	public ImagesEmbeddedPage()
	{
		InitializeComponent();
		BindingContext = new ImagesEmbeddedViewModel();
	}
}