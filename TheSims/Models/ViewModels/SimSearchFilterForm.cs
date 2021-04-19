using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models.ViewModels
{
    public class SimSearchFilterForm
    {
        public Sim Sim { get; set; }
        [Display(Name ="Profession")]
        public int ProfessionID { get; set; }
        public IEnumerable<Profession> Professions { get; set; }

   
        

    }
}
