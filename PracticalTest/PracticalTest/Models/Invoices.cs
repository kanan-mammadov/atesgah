using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class Invoices
    {
        [Key]
        public int InvoiceId { get; set; }
        [Column(TypeName = "int")]
        public int ClientId { get; set; }
        [Column(TypeName = "money")]
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        [Column(TypeName = "DataType.Date")]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }       
        [Column(TypeName = "int")]
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Must be 4 digit max")]
        [DisplayName("InvoiceNr")]
        public int InvoiceNr { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("OrderNr")]
        public int OrderNr { get; set; }
    }
}
