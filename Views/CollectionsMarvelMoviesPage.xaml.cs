namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;
public partial class CollectionsMarvelMoviesPage : ContentPage
{
	public CollectionsMarvelMoviesPage()
	{
		BindingContext = new CollectionsMarvelMoviesViewModel();
		InitializeComponent();
	}
}