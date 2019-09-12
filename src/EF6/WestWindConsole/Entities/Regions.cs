using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindConsole.Entities
{
    [Table("Regions")]
    class Regions
    {
        // Primary Key
        [Required, Key]
        public int RegionID { get; set; }

        public string RegionDescription { get; set; }
    }
}
