using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public User(string userName, string password, string type)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }
    }
}
