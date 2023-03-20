﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KeeperTest.Controllers
{
    public class BaseController : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
