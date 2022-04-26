using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class PlacementContract
    {
        [Key]
        public int PlacementContractId { get; set; }

        [Required]
        public DateTime StartDate { get; set; } //change this

        [Required]
        public DateTime EndDate { get; set; } // change this

        [Required]
        public int LocationId { get; set; }

        [Required]
        public Location Location { get; set; }

        public ICollection<Shift> Shifts { get; set; }
    }
}