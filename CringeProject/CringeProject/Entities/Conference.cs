using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CringeProject.Entities {
    public class Conference
    {
        [Key]
        public int Id { get; set; }

        public virtual List<Section> Sections { get; set; }

        public string Name { get; set; }

        public DateTime AbstractDeadline { get; set; }

        public DateTime PaperDeadline { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
