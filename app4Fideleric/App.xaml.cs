using app4Fideleric.Vues;

namespace app4Fideleric
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AccueilVue());
        }
    }
}
