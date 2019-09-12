using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    class Territories
    {
        [Key, StringLength(20, ErrorMessage = "Territory ID cannot be longer than 20 letters.")]
        public string TerritoryID { get; set; }

        [Required, StringLength(50, ErrorMessage = "Territory Description is too long.")]
        public string TerritoryDescription { get; set; }

        [Key]
        public int RegionID { get; set; }
    }
}
