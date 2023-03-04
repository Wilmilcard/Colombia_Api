using Colombia_Api.Domain.DB;
using Colombia_Api.Domain.Models;
using Colombia_Api.HttpRequest;
using Colombia_Api.Interfaces;
using Colombia_Api.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Colombia_Api.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [Authorize]
    //[AllowAnonymous]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentoServices _departamentoServices;
        private readonly ColombiaApiDbContext _dbContext;
        private readonly IConfiguration configuration;

        public DepartamentoController(IDepartamentoServices departamentoServices, ColombiaApiDbContext dbContext, IConfiguration Configuration)
        {
            _departamentoServices = departamentoServices;
            _dbContext = dbContext;
            configuration = Configuration;
        }

        [HttpGet("[Action]")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var municipios_list = _dbContext.Municipio;

                var query = _departamentoServices
                    .QueryNoTracking()
                    .Include(x => x.Pais)
                    .Where(x => x.PaisId == 1)
                    .Select(x => new
                    {
                        x.DepartamentoId,
                        nombre_pais = x.Pais.Nombre,
                        nombre_departamento = x.Nombre,
                        total_municipios = municipios_list.Where(m => m.DepartamentoId == x.DepartamentoId).ToList().Count,
                        municipios = municipios_list.Where(m => m.DepartamentoId == x.DepartamentoId)
                                        .Select(mu => new
                                        {
                                            mu.MunicipioId,
                                            mu.Nombre
                                        })
                                        .ToList()
                    })
                    .ToList();

                var response = new
                {
                    status = true,
                    data = query
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = false,
                    error_code = ex.HResult,
                    message = ex.Message
                };

                return new BadRequestObjectResult(response);
            }
        }

        [AllowAnonymous]
        [HttpGet("[Action]/{paisId}/{departamentId}")]
        public async Task<ActionResult> GetMunicipiosByDepartamentId(int paisId, int departamentId)
        {
            try
            {
                var municipios_list = _dbContext.Municipio.Where(x => x.DepartamentoId == departamentId);

                var query = _dbContext.Municipio
                    .Include(x => x.Departamento)
                        .ThenInclude(d => d.Pais)
                    .Where(x => x.Departamento.PaisId == paisId && x.DepartamentoId == departamentId)
                    .Select(x => new
                    {
                        x.MunicipioId,
                        x.Nombre,
                        departamento = x.Departamento.Nombre,
                        pais = x.Departamento.Pais.Nombre
                    })
                    .ToList();

                var response = new
                {
                    status = true,
                    data = query
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = false,
                    error_code = ex.HResult,
                    message = ex.Message
                };

                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost("[Action]")]
        public async Task<ActionResult> Create([FromBody] DepartamentoCreateUpdate request)
        {
            try
            {
                var departament = _departamentoServices.QueryNoTracking().Where(x => x.Nombre.ToUpper() == request.Nombre.ToUpper()).FirstOrDefault();
                if (departament != null)
                    return new BadRequestObjectResult(new { status = false, error_code = 400, message = "Ese departamento ya existe" });

                var add = new Departamento
                {
                    Nombre = request.Nombre,
                    PaisId = request.PaisId,
                    CreatedAt = Globals.GetFechaActual(),
                    CreatedBy = Globals.GetCreated()
                };

                //Services
                await _departamentoServices.AddAsync(add);

                //Context
                //await _dbContext.Departamento.AddAsync(add);
                //_dbContext.SaveChanges();

                var response = new
                {
                    status = true,
                    data = add
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = false,
                    error_code = ex.HResult,
                    message = ex.Message
                };

                return new BadRequestObjectResult(response);
            }
        }

        [HttpPut("[Action]/{id}")]
        public async Task<ActionResult> Update([FromBody] DepartamentoCreateUpdate request, int id)
        {
            try
            {
                var departament = _departamentoServices.GetByIdAsync(id).Result;
                if (departament == null)
                    return new BadRequestObjectResult(new { status = false, error_code = 400, message = "Ese departamento no existe" });

                departament.Nombre = request.Nombre;
                departament.PaisId = request.PaisId;
                departament.UpdateAt = Globals.GetFechaActual();

                //Services
                await _departamentoServices.UpdateAsync(departament);

                //Context
                //_dbContext.Departamento.Update(departament);
                //_dbContext.SaveChanges();

                var response = new
                {
                    status = true,
                    data = departament
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = false,
                    error_code = ex.HResult,
                    message = ex.Message
                };

                return new BadRequestObjectResult(response);
            }
        }

        [HttpDelete("[Action]/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                using (var transaction = _dbContext.Database.BeginTransaction())
                {
                    var departament = _departamentoServices.GetByIdAsync(id).Result;
                    if (departament == null)
                        return new BadRequestObjectResult(new { status = false, error_code = 400, message = "Ese departamento no existe" });

                    var municipios = _dbContext.Municipio.Where(x => x.MunicipioId == id).ToList();
                    foreach(var m in municipios)
                        _dbContext.Municipio.Remove(m);

                    await _departamentoServices.DeleteAsync(departament);

                    transaction.Commit();
                }

                var response = new
                {
                    status = true
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = false,
                    error_code = ex.HResult,
                    message = ex.Message
                };

                return new BadRequestObjectResult(response);
            }
        }

    }
}
