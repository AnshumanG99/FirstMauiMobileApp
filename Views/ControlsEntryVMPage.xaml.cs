namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;

public partial class ControlsEntryVMPage : ContentPage
{
	public ControlsEntryVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsEntryVMViewModel();

    }
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (BindingContext is ControlsEntryVMViewModel vm
            && query.TryGetValue("entryText", out var value)
            && value is string text)
        {
            vm.EntryText = text;
        }
    }
}