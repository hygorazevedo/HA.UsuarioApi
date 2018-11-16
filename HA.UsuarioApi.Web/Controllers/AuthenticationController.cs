using HA.UsuarioApi.Domain.Interfaces;
using HA.UsuarioApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HA.UsuarioApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public IInfraDataDapper Dapper { get; set; }

        public AuthenticationController(IInfraDataDapper Dapper)
        {
            this.Dapper = Dapper ?? throw new ArgumentNullException(nameof(Dapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var authenticationGet = new AuthenticationGet
            {
                Login = "hygor.azevedo",
                Password = "testeapi"
            };
            var response = await Dapper.GetDadosUsuarioAsync(authenticationGet);
            
            return Ok(response);
        }
    }
}