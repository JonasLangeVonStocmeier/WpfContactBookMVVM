using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfContactBookMVVM.Models
{
    public class UserManager
    {
        // Hard coded users for test purpose
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() { new User { Email = "john.doe@email.com", Name = "John Doe" }, new User { Email = "kevin.test1@gmail.com", Name = "Kevin Test" }, new User { Email = "TheRealMarkTwain@google.com", Name = "Mark Twain" } };

        public static ObservableCollection<User> GetUsers() 
        { 
            return _DatabaseUsers; 
        }   

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }
    }
}
