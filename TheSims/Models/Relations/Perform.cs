using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSims.Models.Relations
{
    public class Perform
    {
        public int SimID { get; set; }
        [ForeignKey("SimID")]
        public Sim Sim { get; set; }

        public int ActionID { get; set; }
        [ForeignKey("ActionID")]
        public Action Action { get; set; }

        public DateTime LastPerform { get; set; }

    }
}
