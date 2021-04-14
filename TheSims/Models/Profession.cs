using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TheSims.Models
{
    public class Profession
    {
        public int ProfessionID { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
    }
}
