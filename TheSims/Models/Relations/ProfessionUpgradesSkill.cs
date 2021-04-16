using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models.Relations
{
    public class ProfessionUpgradesSkill
    {
        [Key, Column(Order = 0)]
        public int ProfessionID { get; set; }
        [ForeignKey("ProfessionID")]
        public Profession Profession { get; set; }

        [Key, Column(Order = 1)]
        public int SkillID { get; set; }
        [ForeignKey("SkillID")]

        public Skill Skill { get; set; }
    }
}
