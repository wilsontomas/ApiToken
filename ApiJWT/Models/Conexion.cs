using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using ApiJWT.Interfaces;
using Microsoft.Extensions.Configuration;

namespace ApiJWT.Models
{
    public class Conexion
    {
        public IConfiguration _Configuration { get; set; }
        public Conexion(IConfiguration conf)
        {
            this._Configuration =conf;
        }
        private SqlConnection _conexion { get; set; }

        public SqlConnection conexion
        {
            get
            {
                if (this._conexion == null) { this._conexion = new SqlConnection(_Configuration.GetConnectionString("Conexion")); }
                return this._conexion;
            }
        }
    }
}
