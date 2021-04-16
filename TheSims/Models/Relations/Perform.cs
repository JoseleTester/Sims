using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models.Relations
{
    public class Perform
    {
        [Key, Column(Order = 0)]
        public int SimID { get; set; }
        [ForeignKey("SimID")]
        public Sim Sim { get; set; }

        [Key, Column(Order = 1)]
        public int ActionID { get; set; }
        [ForeignKey("ActionID")]
        public Action Action { get; set; }

        public DateTime LastPerform { get; set; }

    }
}
