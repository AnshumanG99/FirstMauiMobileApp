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
            Routing.RegisterRoute(nameof(LayoutsFlexPage), typeof(LayoutsFlexPage));

            //Images

            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));

            //Images Child Page

            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));
            Routing.RegisterRoute(nameof(ImagesActivityIndicatorPage), typeof(ImagesActivityIndicatorPage));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));

            //Collections

            Routing.RegisterRoute(nameof(CollectionsPage), typeof(CollectionsPage));

            //Collections Child Page

            Routing.RegisterRoute(nameof(CollectionsMarvelMoviesPage), typeof(CollectionsMarvelMoviesPage));
            Routing.RegisterRoute(nameof(CollectionsImagesPage), typeof(CollectionsImagesPage));
            Routing.RegisterRoute(nameof(CollectionsButtonsPage), typeof(CollectionsButtonsPage));
            Routing.RegisterRoute(nameof(CollectionsIconsPage), typeof(CollectionsIconsPage));
            Routing.RegisterRoute(nameof(CollectionsAddPage), typeof(CollectionsAddPage));
            Routing.RegisterRoute(nameof(CollectionsEditPage), typeof(CollectionsEditPage));

            //Controls
            Routing.RegisterRoute(nameof(ControlsPage), typeof(ControlsPage));

            //Controls Child Page

            Routing.RegisterRoute(nameof(ControlsSwitchPage), typeof(ControlsSwitchPage));
            Routing.RegisterRoute(nameof(ControlsSliderPage), typeof(ControlsSliderPage));
            Routing.RegisterRoute(nameof(ControlsSliderVMPage), typeof(ControlsSliderVMPage));
            Routing.RegisterRoute(nameof(ControlsSliderXAMLPage), typeof(ControlsSliderXAMLPage));
            Routing.RegisterRoute(nameof(ControlsStepperPage), typeof(ControlsStepperPage));
            Routing.RegisterRoute(nameof(ControlsStepperXAMLPage), typeof(ControlsStepperXAMLPage));
            Routing.RegisterRoute(nameof(ControlsStepperVMPage), typeof(ControlsStepperVMPage));
            Routing.RegisterRoute(nameof(ControlsEntryPage), typeof(ControlsEntryPage));
            Routing.RegisterRoute(nameof(ControlsPickerPage), typeof(ControlsPickerPage));
            Routing.RegisterRoute(nameof(ControlsDateandTimePage), typeof(ControlsDateandTimePage));

        }

    }
}
