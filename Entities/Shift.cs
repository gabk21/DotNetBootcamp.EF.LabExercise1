using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        [Required]
        public int DayOfWeek { get; set; }

        [Required]
        public int StartTime { get; set; } //change this

        [Required]
        public int EndTime { get; set; } //change this

        [Required]
        public int NumberOfEmployees { get; set; } //change this

        [Required]
        public bool Active { get; set; } //cjhange this
        
        public string? Notes { get; set; } //change this

        [Required]
        public int PlacementContractId { get; set; }

        public PlacementContract PlacementContract { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
