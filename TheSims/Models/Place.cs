using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models
{
    public class Place
    {
        public int PlaceID { get; set; }
        public int Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
    }
}
