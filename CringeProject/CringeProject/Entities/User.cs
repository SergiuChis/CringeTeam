using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities.Users
{
    class User
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Type { get; set; }

        public User(string userName, string password, string type)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }
    }
}
