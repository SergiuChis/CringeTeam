using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities {
    public class Review {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public User User { get; set; }

        public int PaperId { get; set; }
        public Paper Paper { get; set; }

        public string Grade { get; set; }
    }
}
