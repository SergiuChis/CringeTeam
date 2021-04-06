using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public Paper Paper { get; set; }
        public virtual ICollection<Section> Sections { get; set; }

        public User(string userName, string password, UserType type)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Type = type.Type ?? throw new ArgumentNullException(nameof(type));
        }
    }
}
