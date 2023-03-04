using Colombia_Api.Domain.DB;
using Colombia_Api.Interfaces;
using Colombia_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System;
using Colombia_Api.HttpRequest;
using Colombia_Api.Domain.Models;
using System.Linq;
using Colombia_Api.Utils;
using static System.Collections.Specialized.BitVector32;

namespace Colombia_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ColombiaApiDbContext _dbContext;
        private readonly IConfiguration configuration;

        public AuthController(ColombiaApiDbContext dbContext, IConfiguration Configuration)
        {
            _dbContext = dbContext;
            configuration = Configuration;
        }

        [HttpPost("[Action]")]
        public async Task<ActionResult> Auth([FromBody] LoginRequest request)
        {
            try
            {
                var rpta = new Session();

                using (var transaction = _dbContext.Database.BeginTransaction())
                {
                    var user = _dbContext.User.Where(x => x.Username == request.Username).FirstOrDefault();
                    if (user == null)
                        return new BadRequestObjectResult(new { status = false, error_code = 400, message = "Ese usuario no existe" });

                    //Encript
                    if (user.Password != request.Password)
                        return new BadRequestObjectResult(new { status = false, error_code = 401, message = "Contraseña incorrecta" });

                    var expiration_date = Globals.GetFechaActual().AddHours(12);
                    var jwtHelper = new JWTHelpers(configuration.GetValue<string>("SecurityKey"));
                    var token = jwtHelper.CreateToken(request.Username, expiration_date);

                    var _session = _dbContext.Session.Where(x => x.UserId == user.UserId).FirstOrDefault();
                    if (_session == null)
                    {
                        var sesion = new Session()
                        {
                            UserId = user.UserId,
                            ExpirationDate = expiration_date,
                            Token = token,
                            CreatedBy = Globals.GetCreated(),
                            CreatedAt = Globals.GetFechaActual()
                        };

                        await _dbContext.Session.AddAsync(sesion);
                        rpta = sesion;
                    }
                    else
                    {
                        _session.ExpirationDate = expiration_date;
                        _session.Token = token;
                        _session.UpdateAt = Globals.GetFechaActual();

                        _dbContext.Session.Update(_session);
                        rpta = _session;
                    };

                    _dbContext.SaveChanges();
                    

                    transaction.Commit();
                }

                var response = new
                {
                    status = true,
                    data = new
                    {
                        rpta.User.Username,
                        rpta.Token,
                        rpta.ExpirationDate
                    }
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
