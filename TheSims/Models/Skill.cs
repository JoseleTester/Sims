using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
