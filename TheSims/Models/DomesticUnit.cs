    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    namespace TheSims.Models
    {
        public class DomesticUnit
        {
            public int DomesticUnitID { get; set; }
            public int RoomNumber { get; set; }
            public int BathroomNumber { get; set; }
            public string Description { get; set; }
        }
    }
