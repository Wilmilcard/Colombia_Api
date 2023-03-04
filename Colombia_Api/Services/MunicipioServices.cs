using Colombia_Api.Domain.Models;
using Colombia_Api.Domain.Repository;
using Colombia_Api.Interfaces;

namespace Colombia_Api.Services
{
    public class MunicipioServices : BaseRepository<Municipio>, IMunicipioServices
    {
        public MunicipioServices(IRepository<Municipio> repository) : base(repository)
        {

        }
    }
}
