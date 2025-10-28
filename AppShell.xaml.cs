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
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));

            //Layouts Child Page 
            Routing.RegisterRoute(nameof(LayoutsStackPage), typeof(LayoutsStackPage));
            Routing.RegisterRoute(nameof(LayoutsVerticalPage), typeof(LayoutsVerticalPage));
            Routing.RegisterRoute(nameof(LayoutsHorizontalPage), typeof(LayoutsHorizontalPage));
            Routing.RegisterRoute(nameof(LayoutsAbsolutePage), typeof(LayoutsAbsolutePage));


        }

    }
}
