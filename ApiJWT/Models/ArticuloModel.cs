using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiJWT.Models
{
   public class ArticuloModel
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Articulo { get; set; }
        public int IdCategoria { get; set; }
        public int IdPais { get; set; }
    }
}
