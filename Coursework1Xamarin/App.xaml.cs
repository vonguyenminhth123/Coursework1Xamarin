using System.Collections.ObjectModel;

namespace Coursework1Xamarin
{
    public partial class App : Application
    {
        public ObservableCollection<Hike> HikeList;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}