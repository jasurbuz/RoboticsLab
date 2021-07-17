using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    class StudentModel : PersonModel
    {
        public int JurnalId { get; set; }
        public int PaymentId { get; set; }
        public string Group { get; set; }
    }
}
