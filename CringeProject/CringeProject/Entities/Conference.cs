using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities {
    public class Conference {
        public string Name { get; set; }
        public DateTime SubmissionDeadline { get; set; }
        public List<User> Users { get; set; }
        public List<Section> Sections { get; set; }
        public User Chair { get; set; }
    }
}
