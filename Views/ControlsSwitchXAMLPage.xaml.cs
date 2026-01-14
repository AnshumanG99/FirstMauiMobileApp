using FirstMauiMobileApp.ViewModels;
namespace FirstMauiMobileApp.Views;

public partial class ControlsSwitchXAMLPage : ContentPage
{
    public ControlsSwitchXAMLPage()
    {
        InitializeComponent();
        BindingContext = new ControlsSwitchXAMLViewModel();
    }

    private void SwitchToggled(object sender, ToggledEventArgs e)
    {

        label.TextColor = e.Value
            ? Color.FromRgb(0, 0, 255)
            : Color.FromRgb(255, 0, 0);
    }

}