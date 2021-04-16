using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheSims.Models.Relations
{
    public class NeighborhoodPlaces
    {
        [Key, Column(Order = 0)]
        public int NeighborhoodID { get; set; }
        [ForeignKey("NeighborhoodID")]
        public Neighborhood Neighborhood { get; set; }

        [Key, Column(Order = 1)]
        public int PlaceID { get; set; }
        [ForeignKey("PlaceID")]
        public Place Place { get; set; }
    }
}
