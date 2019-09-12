using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindConsole.Entities
{
    [Table("PaymentTypes")]
    class PaymentTypes
    {
        [Key]
        public byte PaymentTypeID { get; set; }

        [Required, StringLength(40, ErrorMessage = "Payment type description is too long.")]
        public string PaymentTypeDescription { get; set; }
    }
}
