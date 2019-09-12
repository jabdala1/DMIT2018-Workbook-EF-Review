using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    class Orders
    {
        [Key]
        public int OrderID { get; set; }

        public int SalesRepID { get; set; }
        [StringLength(5, ErrorMessage = "CustomerID is only 5 characters long.")]
        public string CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime PaymentDueDate { get; set; }

        public decimal Freight { get; set; }

        [Required]
        public bool Shipped { get; set; }
        [StringLength(40, ErrorMessage = "Ship name is too long.")]
        public string ShipName { get; set; }

        public int ShipAddressID { get; set; }
        [StringLength(250, ErrorMessage = "Comment is too long.")]
        public string Comments { get; set; }
    }
}
