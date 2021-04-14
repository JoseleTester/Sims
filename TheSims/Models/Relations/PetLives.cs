﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSims.Models.Relations
{
    public class PetLives
    {
        public int PetID { get; set; }
        [ForeignKey("PetID")]
        public Pet Pet { get; set; }

        public int DomesticUnitID { get; set; }
        [ForeignKey("DomesticUnitID")]
        public DomesticUnit DomesticUnit { get; set; }
    }
}