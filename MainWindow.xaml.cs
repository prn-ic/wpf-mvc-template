using KeeperTest.Views;
using System.Windows;

namespace KeeperTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavigationStore.Navigate(new LoginPage());
        }
    }
}
