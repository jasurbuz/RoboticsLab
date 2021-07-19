using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    abstract class Person
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("firstname")]
        public string FirstName { get; set; }
        [Required]
        [Column("lastname")]
        public string LastName { get; set; }
        [Column("middlename")]
        public string MiddleName { get; set; }
        [Required]
        [Column("birthday")]
        public DateTime Birthday { get; set; }
        [Required]
        [Column("faceid")]
        public int FaceId { get; set; }
        [Required]
        [Column("touchid")]
        public int TouchId { get; set; }
    }
}
