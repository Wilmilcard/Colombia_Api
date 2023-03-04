using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.Models
{
    public class Persona
    {
        public int PersonaID { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Nacimiento { get; set; }
        public int MunicipioID { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
