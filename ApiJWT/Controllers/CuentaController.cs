using ApiJWT.Interfaces;
using ApiJWT.Models;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJWT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        public readonly SqlConnection _conexion;
        private readonly ITokenProvider tokenProvider;

        public CuentaController(Conexion conexion, ITokenProvider tokenProvider) {
            _conexion = conexion.conexion;
            this.tokenProvider = tokenProvider;
        }

        [HttpPost("Autenticar")]
        [AllowAnonymous]
        public IActionResult Autenticar([FromForm]string nombre, [FromForm] string clave) 
        {
            var parametros = new { @nombre = nombre, @Clave = clave };
            var resultado = _conexion.QuerySingleOrDefault<Usuario>("validarUsuario",parametros,commandType: CommandType.StoredProcedure);
            if (resultado == null) {
                return BadRequest("Credenciales invalidas");
            }
            DateTime expiration = DateTime.UtcNow.AddHours(24);
            int expirationInHours = 24;
            var token = tokenProvider.createtoken(resultado, expiration);
            return Ok(new { 
            token=token,
            expires_in= expirationInHours * 60 * 60
            });
        }

        [HttpGet("Validar")]
        [Authorize]
        public IActionResult validar() {
            //var tvp = tokenProvider.getValidationParameters()
            
            return Ok("Acceso permitido");
        }
    }
}
