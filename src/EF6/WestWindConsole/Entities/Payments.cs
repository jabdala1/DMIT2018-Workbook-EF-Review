using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindConsole.Entities
{
    [Table("Payments")]
    class Payments
    {
        [Key]
        public int PaymentID { get; set; }

        public DateTime PaymentDate { get; set; }

        public double Amount { get; set; }

        public byte PaymentTypeID { get; set; }

        public int OrderID { get; set; }

        public Guid TransactionID { get; set; }

        public DateTime ClearedDate { get; set; }
    }
}
