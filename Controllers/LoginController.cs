using System.Windows.Input;

namespace KeeperTest.Controllers
{
    public class LoginController: BaseController
    {
        private string? name = "Хранитель про";
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public void Login()
        {
            Name = "Стражник";
        }
    }
}
