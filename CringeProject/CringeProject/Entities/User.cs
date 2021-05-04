using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CringeProject.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}
