using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
    }
}
