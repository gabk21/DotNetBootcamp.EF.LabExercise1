using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        public DateTime Day { get; set; }

        [Required]
        public decimal HourlyWage { get; set; } //change this in DB

        [Required]
        public bool OverTime { get; set; } //change this ind DB

        [Required]
        public int ShiftId { get; set; }

        public Shift Shift { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
