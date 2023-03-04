using Colombia_Api.Domain.Models;
using Colombia_Api.Domain.Repository;
using Colombia_Api.Interfaces;

namespace Colombia_Api.Services
{
    public class DepartamentoServices : BaseRepository<Departamento>, IDepartamentoServices
    {
        public DepartamentoServices(IRepository<Departamento> repository) : base(repository)
        {

        }
    }
}
