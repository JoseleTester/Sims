using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models.Relations
{
    public class SimSkills
    {
        [Key, Column(Order = 0)]
        public int SimID { get; set; }
        [ForeignKey("SimID")]
        public Sim Sim { get; set; }

        [Key, Column(Order = 1)]
        public int SkillID { get; set; }
        [ForeignKey("SkillID")]
        public Skill Skill { get; set; }
        
        [Range(0,10)]
        public int Points { get; set; }
    }
}
