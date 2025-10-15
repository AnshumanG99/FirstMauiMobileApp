using FirstMauiMobileApp.Views;

namespace FirstMauiMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
    
        private void RegisterRoutes()
        {
            //Layouts
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
        
            //Layouts Child Page 
        }

    }
}
