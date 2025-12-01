namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class CollectionsImagesPage : ContentPage
{
	public CollectionsImagesPage()
	{
        BindingContext = new CollectionsImagesViewModel();
        InitializeComponent();
    }
}