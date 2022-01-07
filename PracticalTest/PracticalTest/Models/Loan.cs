using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        [Column(TypeName = "int")]
        public int ClientId { get; set; }
        [Column(TypeName = "money")]
        [Range(100, 5000)]
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("InterestRate")]
        public string InterestRate { get; set; }
        [Column(TypeName = "int")]
        [Range(3, 24)]
        [DisplayName("Loan Period")]
        public int LoanPeriod { get; set; }
        [Column(TypeName = "DataType.Date")]
        [DisplayName("Payout Date")]
        public DateTime PayoutDate { get; set; }

   

    }
}
