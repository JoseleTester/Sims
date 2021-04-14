using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models.Relations
{
    public class Travel
    {
        [Key]
        public DateTime Date { get; set; }

        public int SimID { get; set; }
        [ForeignKey("SimID")]
        public Sim Sim { get; set; }

        public int WorldID { get; set; }
        [ForeignKey("WorldID")]
        public World World { get; set; }
    }
}
