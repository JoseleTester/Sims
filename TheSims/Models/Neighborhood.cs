using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models
{
    public class Neighborhood
    {
        public int NeighborhoodID { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
    }
}
