using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfContactBookMVVM.Models
{
    public class User
    {
        public User()
        {
            
        }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public string? Telephone { get; set; }

    }
}
