using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Column(TypeName = "nvarchar(250)")]       
        [DisplayName("Name")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("TelephoneNr")]
        public string TelephoneNr { get; set; }
    }
}
