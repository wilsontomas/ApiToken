using ApiJWT.Models;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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

        [HttpGet("ObtenerNoticiasPorCategoria")]
        [Authorize]
        public IEnumerable<ArticulosNoticias> ObtenerNoticiasPorCategoria( int categoria)
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
        

        [HttpGet("ObtenerNoticiasPorPais")]
        [Authorize]
        public IEnumerable<ArticulosNoticias> ObtenerNoticiasPorPais(int pais)
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
        
        [HttpGet("ObtenerNoticiaPorId")]
        [Authorize]
        public ArticulosNoticias ObtenerNoticiaPorId( int id)
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

        [HttpGet("ObtenerNoticiaPorBusqueda")]
        [Authorize]
        public IEnumerable<ArticulosNoticias> ObtenerNoticiaPorBusqueda(string termino)
        {
            var parametros = new { @termino = termino };
            if (termino == null) return null;
            try
            {
                var noticia = _conexion.Query<ArticulosNoticias>("ObtenerNoticiaPorBusqueda", parametros, commandType: System.Data.CommandType.StoredProcedure);
                return noticia;
            }
            catch
            {
                return null;
            }
        }

        [HttpPost("InsertarNoticia")]
        [Authorize]
        public IActionResult InsertarNoticia( [FromBody] ArticuloModel model)
        {
            if (!string.IsNullOrEmpty(model.Titulo) || !string.IsNullOrEmpty(model.Articulo) || model.IdCategoria ==0 || model.IdPais ==0)
            {
            
            var parametros = new { @Titulo= model.Titulo, @Articulo= model.Articulo, @CategoriaId = model.IdCategoria, @PaisId = model.IdPais };
            if (model.Titulo == null || model.Articulo ==null || model.IdCategoria ==0 || model.IdPais ==0) return BadRequest("No se pudo insertar la noticia, faltan parametros");
                try
            {
                var noticia = _conexion.Query("InsertarNoticia", parametros, commandType: System.Data.CommandType.StoredProcedure);
                return Ok("Se inserto la noticia");
            }
            catch
            {
                return BadRequest("No se pudo insertar la noticia");
            }

            }
            else { return BadRequest("Faltan parametros"); }
        }

        [HttpPost("EliminarNoticia")]
        [Authorize]
        public IActionResult EliminarNoticia([FromBody] EliminarModel eliminarModels)
        {
            
                var parametros = new { @IdNoticia = eliminarModels.IdNoticia };
                try
                {
                    var noticia = _conexion.Query("EliminarNoticia", parametros, commandType: System.Data.CommandType.StoredProcedure);
                    return Ok("Se Elimino la noticia");
                }
                catch
                {
                    return BadRequest("No se pudo Eliminar la noticia ");
                }

             }

        [HttpPost("EditarNoticia")]
        [Authorize]
        public IActionResult EditarNoticia([FromBody] ArticuloModel model)
        {
            if (!string.IsNullOrEmpty(model.Titulo) || !string.IsNullOrEmpty(model.Articulo) || model.IdCategoria == 0 || model.IdPais == 0)
            {

                var parametros = new {@IdNoticias=model.IdNoticia, @Titulo = model.Titulo, @Articulo = model.Articulo, @CategoriaId = model.IdCategoria, @PaisId = model.IdPais };
                if (model.Titulo == null || model.Articulo == null || model.IdCategoria == 0 || model.IdPais == 0) return BadRequest("No se pudo editar la noticia, faltan parametros");
                try
                {
                    var noticia = _conexion.Query("EditarNoticia", parametros, commandType: System.Data.CommandType.StoredProcedure);
                    return Ok("Se edito la noticia");
                }
                catch(Exception er)
                {
                    return BadRequest(er.Message);
                }

            }
            else { return BadRequest("Faltan parametros"); }
        }
    }
}
