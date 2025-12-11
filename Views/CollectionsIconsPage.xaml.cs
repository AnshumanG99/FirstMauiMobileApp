namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class CollectionsIconsPage : ContentPage
{
	public CollectionsIconsPage(CollectionsUpdateableViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

    }
}