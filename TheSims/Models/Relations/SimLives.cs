using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSims.Models.Relations
{
    public class SimLives
    {
        public int SimID { get; set; }
        [ForeignKey("SimID")]
        public Sim Sim { get; set; }

        public int DomesticUnitID { get; set; }
        [ForeignKey("DomesticUnitID")]
        public DomesticUnit DomesticUnit { get; set; }
    }
}
    