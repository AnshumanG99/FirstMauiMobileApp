namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ImagesActivityIndicatorPage : ContentPage
{
	public ImagesActivityIndicatorPage()
	{
		InitializeComponent();
		BindingContext = new ImagesActivityIndicatorViewModel();
	}
}