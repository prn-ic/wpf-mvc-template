using KeeperTest.Controllers;
using System.Windows.Controls;

namespace KeeperTest.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        LoginController loginController = new LoginController();
        public LoginPage()
        {
            InitializeComponent();
            DataContext = loginController;
        }
        private void Login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            loginController.Login();
            this.NavigationService.Navigate(new ApplicationPage());
        }
    }
}
