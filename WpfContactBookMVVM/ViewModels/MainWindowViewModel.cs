using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfContactBookMVVM.Commands;
using WpfContactBookMVVM.Models;
using WpfContactBookMVVM.Views;

namespace WpfContactBookMVVM.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public MainWindowViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindowMethod, CanShowWindow);

        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindowMethod(object obj)
        {
            
            AddUser adduserWindow = new AddUser();

            adduserWindow.Show();

        }
    }
}
