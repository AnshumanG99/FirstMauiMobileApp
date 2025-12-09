using FirstMauiMobileApp.ViewModels;
namespace FirstMauiMobileApp.Views;

public partial class CollectionsButtonsPage : ContentPage
{
	public CollectionsButtonsPage(CollectionsUpdateableViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;

    }
}