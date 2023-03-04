using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.Models
{
    public class Municipio : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("MunicipioId")]
        public int MunicipioId { get; set; }
        public string Nombre { get; set; }
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }

    }
}
