using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.Models
{
    public class Session : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("SessionId")]
        public int SessionId { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UserId { get; set; }
        //
        public virtual User User { get; set; }
    }
}
