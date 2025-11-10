using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using FirstMauiMobileApp.Models.Titles;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace FirstMauiMobileApp.ViewModels
{
    public partial class ImagesActivityIndicatorViewModel : ObservableObject
    {
        public string Title => TitleImagesActivityIndicator.ActivityIndicatorTitle;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ImagesActivityIndicatorViewModel()
        {
            _ = LoadImageAsync();
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleImagesURI.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading image: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
