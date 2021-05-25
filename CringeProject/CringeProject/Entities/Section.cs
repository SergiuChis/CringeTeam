using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CringeProject.Entities {
    public class Section {
        [Key]
        public int Id { get; set; }

        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }

        public string Room { get; set; }
        public int AvailablePlaces { get; set; } //number of seats or smth

        public override string ToString() {
            return $"{ConferenceId} - {Room} ({AvailablePlaces})";
        }
    }
}