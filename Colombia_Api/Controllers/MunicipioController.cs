using Colombia_Api.Domain.Models;
using Colombia_Api.HttpRequest;
using Colombia_Api.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Colombia_Api.Domain.DB;
using Colombia_Api.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Collections.Generic;
using Colombia_Api.Services;

namespace Colombia_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly IMunicipioServices _municipioServices;
        private readonly ColombiaApiDbContext _dbContext;
        private readonly IConfiguration configuration;

        public MunicipioController(IMunicipioServices municipioServices, ColombiaApiDbContext dbContext, IConfiguration Configuration)
        {
            _municipioServices = municipioServices;
            _dbContext = dbContext;
            configuration = Configuration;
        }

        [HttpPost("[Action]")]
        public async Task<ActionResult> Create([FromBody] List<MunicipioCreateUpdate> request)
        {
            try
            {
                using(var transaction = _dbContext.Database.BeginTransaction())
                {
                    foreach (var m in request)
                    {
                        var municipio = _municipioServices.QueryNoTracking().Where(x => x.Nombre.ToUpper() == m.Nombre.ToUpper()).FirstOrDefault();
                        if (municipio != null)
                            return new BadRequestObjectResult(new { status = false, error_code = 400, message = $"El Municipio {m.Nombre} ya existe" });

                        var departament = _dbContext.Departamento.Where(x => x.DepartamentoId == m.DepartamentoId).FirstOrDefault();
                        if (departament == null)
                            return new BadRequestObjectResult(new { status = false, error_code = 400, message = $"El departamento {departament.Nombre} no existe" });


                        var add = new Municipio
                        {
                            Nombre = m.Nombre,
                            DepartamentoId = m.DepartamentoId,
                            CreatedAt = Globals.GetFechaActual(),
                            CreatedBy = Globals.GetCreated()
                        };


                        await _dbContext.Municipio.AddAsync(add);
                        _dbContext.SaveChanges();
                    }

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
