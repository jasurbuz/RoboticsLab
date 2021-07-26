﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    [Table("face")]
    class Payment
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
    }
}
