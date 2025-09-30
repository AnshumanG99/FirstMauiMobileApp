using FirstMauiMobileApp.Models.Titles;
using FirstMauiMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstMauiMobileApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string Layouts { get; set; } = TitleMain.Layouts;
        public string Images { get; set; } = TitleMain.Images;
        public string Collections { get; set; } = TitleMain.Collections;
        public string Controls { get; set; } = TitleMain.Controls;
        public string SQLite { get; set; } = TitleMain.SQLite;


        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }

        public MainViewModel() 
        {
            Title = TitleMain.Title;

            //Set Commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
    }
}
