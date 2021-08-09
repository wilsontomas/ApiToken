using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJWT.Models
{
    public class NoticiaModel
    {
        public string Titulo { get; set; }
        public string Articulo { get; set; }
        public int IdCategoria { get; set; }
        public int IdPais { get; set; }
    }
}
