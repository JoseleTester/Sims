using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models
{
    public class Sim
    {
        public int SimID { get; set; }

        [Required]
        [StringLength(127)]
        public string Name { get; set; }

        [Required]
        [StringLength(127)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public double Money { get; set; }

        [Range(0, 1)]
        public byte Gender { get; set; }
        public string LifeStage { get; set; }

        
        public static readonly byte Female = 0;
        public static readonly byte Male = 1;
    }
}
