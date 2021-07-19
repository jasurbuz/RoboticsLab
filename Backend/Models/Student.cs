using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    [Table("student")]
    class Student : Person
    {
        [Required]
        [Column("jurnalid")]
        public int JurnalId { get; set; }
        [Required]
        [Column("paymentid")]
        public int PaymentId { get; set; }
        [Required]
        [Column("group")]
        public string Group { get; set; }
    }
}
