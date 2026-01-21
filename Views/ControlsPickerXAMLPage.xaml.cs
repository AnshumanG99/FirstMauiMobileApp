namespace FirstMauiMobileApp.Views;
using FirstMauiMobileApp.ViewModels;
using Microsoft.Maui.ApplicationModel.Communication;

public partial class ControlsPickerXAMLPage : ContentPage
{
	private readonly Dictionary<string, string> _carImages = new()
	{
		{ "1970 Chevy Corvette", "audi.png" },
		{ "1979 Chevy Camaro", "bmw.png" },
		{ "1978 Chevy Nova", "ford.png" },
		{ "1975 Dodge Charger", "honda.png" },
		{ "1972 Pontiac GTO", "mercedes.png" },
		{ "Toyota", "toyota.png" },
	};

    public ControlsPickerXAMLPage()
	{
        InitializeComponent();
		BindingContext = new ControlsPickerViewModel();

        btnSubmit.Source = Buttons.ButtonSubmit();
    }

    private async void btnSubmit_Clicked(object sender, EventArgs e)
    {
        string selectedCar = pickerXAML.SelectedItem?.ToString() ?? string.Empty;

        if (string.IsNullOrEmpty(selectedCar))
        {
            await DisplayAlert("Selection Required", "Please select a car from the picker.", "OK");
            return;
        }

        if (!_carImages.TryGetValue(selectedCar, out string imageFile))
        {
            await DisplayAlert("Error", "Selected car image not found.", "OK");
            return;
        }

        await Shell.Current.GoToAsync($"{nameof(ControlsPickerResultsPage)}" +
                                      $"?car={Uri.EscapeDataString(selectedCar)}" +
                                      $"&image={Uri.EscapeDataString(imageFile)}"
        );
    }
}
