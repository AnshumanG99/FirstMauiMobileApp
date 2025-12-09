namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;
public partial class CollectionsAddPage : ContentPage
{
	public CollectionsAddPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsAddViewModel();
    }
}