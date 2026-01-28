using CollectionViewEjemplo.Pages;

namespace CollectionViewEjemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Pages.CollectionViewDemo());

        }

    }
}