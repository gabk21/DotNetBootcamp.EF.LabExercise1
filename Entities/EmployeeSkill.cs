using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class EmployeeSkill
    {
        [Key]
        public int EmployeeSkillId { get; set; }

        [Required]
        public int Level { get; set; }

        public int? YearsOfExperience { get; set; }

        [Required]
        public decimal HourlyWage { get; set; } //change this in SSMS, uncomment if done

        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required]
        public int SkillId { get; set; }

        public Skill Skill { get; set; }

    }
}