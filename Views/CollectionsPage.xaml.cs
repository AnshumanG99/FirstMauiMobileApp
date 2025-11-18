namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class CollectionsPage : ContentPage
{
	public CollectionsPage()
	{
		BindingContext = new CollectionsViewModel();
        InitializeComponent();
	}
}