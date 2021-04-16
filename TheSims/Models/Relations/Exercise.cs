using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models.Relations
{
    public class Exercise
    {
        [Key, Column(Order = 0)]
        public int SimID { get; set; }
        [ForeignKey("SimID")]
        public Sim Sim { get; set; }

        [Key, Column(Order = 1)]
        public int ProfessionID { get; set; }
        [ForeignKey("ProfessionID")]
        public Profession Profession { get; set; }

        [Range(1,10)]
        public int Level { get; set; }
    }
}
