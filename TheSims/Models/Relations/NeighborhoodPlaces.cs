using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSims.Models.Relations
{
    public class NeighborhoodPlaces
    {
        public int NeighborhoodID { get; set; }
        [ForeignKey("NeighborhoodID")]
        public Neighborhood Neighborhood { get; set; }

        public int PlaceID { get; set; }
        [ForeignKey("PlaceID")]
        public Place Place { get; set; }
    }
}
