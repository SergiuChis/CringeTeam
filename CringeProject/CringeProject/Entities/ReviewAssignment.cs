using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CringeProject.Entities {
    public class ReviewAssignment {
        [Key, Column(Order = 0)]
        public string UserName { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public int PaperId { get; set; }
        public Paper Paper { get; set; }
    }
}
