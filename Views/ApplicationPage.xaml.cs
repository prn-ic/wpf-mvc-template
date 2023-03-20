using KeeperTest.Controllers;
using System.Windows.Controls;

namespace KeeperTest.Views
{
    /// <summary>
    /// Логика взаимодействия для ApplicationPage.xaml
    /// </summary>
    public partial class ApplicationPage : Page
    {
        ApplicationController controller = new ApplicationController();
        public ApplicationPage()
        {
            InitializeComponent();
        }
    }
}
