using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.Models
{
    public class User : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
