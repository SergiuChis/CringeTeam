using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace CringeProject.Entities
{
    public class Paper
    {
        [Key]
        public int Id { get; set; }

        /*//public int UserId { get; set; }
        //public User User { get; set; }

        //public int SectionId { get; set; }
        //public Section Section { get; set; }

        public string Abstract { get; set; }
        public string Body { get; set; } //TODO: change this from path to actual file*/

    }
}
