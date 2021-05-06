using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CringeProject.Entities {
    public class Participation
    {
        [Key, Column(Order = 0)]
        public string UserName { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public int SectionId { get; set; }
        public Section Section { get; set; }

        public string UserType { get; set; }
    }
}
