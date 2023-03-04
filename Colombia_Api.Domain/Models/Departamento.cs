using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.Models
{
    public class Departamento : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("DepartamentoId")]
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
