using ApiJWT.Models;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        public readonly SqlConnection _conexion;
       

        public NoticiasController(Conexion conexion)
        {
            _conexion = conexion.conexion;
           
        }
        [HttpGet("ObtenerNoticias")]
        [Authorize]
        public IEnumerable<ArticulosNoticias> ObtenerNoticias() {
            try { 
                var listaNoticias = _conexion.Query<ArticulosNoticias>("ObtenerNoticiasModel",null,commandType:System.Data.CommandType.StoredProcedure);
                    return listaNoticias;
            } catch {

                return null;
            }
          
           
        }

        [HttpGet("ObtenerCategoria")]
        [Authorize]
        public IEnumerable<Categoria> ObtenerCategoria()
        {
            try
            {
                var listaCategoria = _conexion.Query<Categoria>("ObtenerCategoria", null, commandType: System.Data.CommandType.StoredProcedure);
                return listaCategoria;
            }
            catch
            {
                return null;
            }
        }

        [HttpGet("ObtenerPais")]
        [Authorize]
        public IEnumerable<Pais> ObtenerPais()
        {
            try
            {
                var listaPais = _conexion.Query<Pais>("ObtenerPais", null, commandType: System.Data.CommandType.StoredProcedure);
                return listaPais;
            }
            catch
            {
                return null;
            }
        }

        [HttpPost("ObtenerNoticiasPorCategoria")]
        [Authorize]
        public IEnumerable<ArticulosNoticias> ObtenerNoticiasPorCategoria([FromForm] int categoria)
        {
            var parametros = new { @idcategoria = categoria };
            if (categoria == 0) return null;
            try
            {
                var listaNoticias = _conexion.Query<ArticulosNoticias>("ObtenerNoticiasPorCategoria", parametros, commandType: System.Data.CommandType.StoredProcedure);
                return listaNoticias;
            }
            catch
            {
                return null;
            }
        }
        

        [HttpPost("ObtenerNoticiasPorPais")]
        [Authorize]
        public IEnumerable<ArticulosNoticias> ObtenerNoticiasPorPais([FromForm] int pais)
        {
            var parametros = new { @idpais = pais };
            if (pais == 0) return null;
            try
            {
                var listaNoticias = _conexion.Query<ArticulosNoticias>("ObtenerNoticiasPorPais", parametros, commandType: System.Data.CommandType.StoredProcedure);
                return listaNoticias;
            }
            catch
            {
                return null;
            }
        }
        
        [HttpPost("ObtenerNoticiaPorId")]
        [Authorize]
        public ArticulosNoticias ObtenerNoticiaPorId([FromForm] int id)
        {
            var parametros = new { @IdNoticia = id };
            if (id == 0) return null;
            try
            {
                var noticia = _conexion.QuerySingleOrDefault<ArticulosNoticias>("ObtenerNoticiaPorId", parametros, commandType: System.Data.CommandType.StoredProcedure);
                return noticia;
            }
            catch
            {
                return null;
            }
        }

        [HttpPost("ObtenerNoticiaPorBusqueda")]
        [Authorize]
        public ArticulosNoticias ObtenerNoticiaPorBusqueda([FromHeader]string termino)
        {
            var parametros = new { @termino = termino };
            if (termino == null) return null;
            try
            {
                var noticia = _conexion.QuerySingleOrDefault<ArticulosNoticias>("ObtenerNoticiaPorBusqueda", parametros, commandType: System.Data.CommandType.StoredProcedure);
                return noticia;
            }
            catch
            {
                return null;
            }
        }
    }
}
