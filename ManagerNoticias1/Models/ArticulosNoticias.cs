using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJWT.Models
{
    public class ArticulosNoticias
    {
        public int IdNoticias { get; set; }
        public string Titulo { get; set; }
        public string Articulo { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCategoria { get; set; }
        public string NombrePais { get; set; }
    }
}
