using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSims.Models.Relations
{
    public class SkillActions
    {
        public int SkillID { get; set; }
        [ForeignKey("SkillID")]
        public Skill Skill { get; set; }

        public int ActionID { get; set; }
        [ForeignKey("ActionID")]
        public Action Action { get; set; }
    }
}
