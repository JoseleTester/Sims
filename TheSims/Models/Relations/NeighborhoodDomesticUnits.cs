using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSims.Models.Relations
{
    public class NeighborhoodDomesticUnits
    {
        public int NeighborhoodID { get; set; }
        [ForeignKey("NeighborhoodID")]
        public Neighborhood Neighborhood { get; set; }

        public int DomesticUnitID { get; set; }
        [ForeignKey("DomesticUnitID")]
        public DomesticUnit DomesticUnit { get; set; }

    }
}
