using ApiJWT.Interfaces;
using ApiJWT.Models;
using Dapper;
using Microsoft.AspNetCore.Authorization;
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

        public CuentaController(Conexion conexion) {
            _conexion = conexion.conexion;
        }

        [HttpPost("Autenticar")]
        [AllowAnonymous]
        public IActionResult Autenticar(string nombre, string clave) 
        {
            var parametros = new { @nombre = nombre, @Clave = clave };
            var resultado = _conexion.QuerySingleOrDefault<Usuario>("validarUsuario",parametros,commandType: CommandType.StoredProcedure);
            if (resultado == null) {
                return BadRequest("Credenciales invalidas");
            }
            return Ok("ok");
        }
    }
}
