using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities {
    public class Bid {
        [Key, Column(Order = 0)]
        public string UserName { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public int PaperId { get; set; }
        public Paper Paper { get; set; }

        public string Interest { get; set; }

        public override string ToString() {
            return $"{this.UserName} - {this.PaperId} ({this.Interest})";
        }
    }
}
