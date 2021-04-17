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
    
        public string Gender { get; set; }
        [Display(Name ="Life Stage")]
        public string LifeStage { get; set; }

        
     
    }
}
