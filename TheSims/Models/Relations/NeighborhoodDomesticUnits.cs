using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models.Relations
{
    public class NeighborhoodDomesticUnits
    {
        [Key, Column(Order = 0)]
        public int NeighborhoodID { get; set; }
        [ForeignKey("NeighborhoodID")]
        public Neighborhood Neighborhood { get; set; }

        [Key, Column(Order = 1)]
        public int DomesticUnitID { get; set; }
        [ForeignKey("DomesticUnitID")]
        public DomesticUnit DomesticUnit { get; set; }

    }
}
