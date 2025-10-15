using FirstMauiMobileApp.Views;

namespace FirstMauiMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new AppShell();
        }
    }
}
