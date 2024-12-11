using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class Conexion
    {
        private readonly string ConexionString;

        public Conexion()
        {
            ConexionString = "Server=(local)\\L-ERAMIREZ; database=ActividadesDB; integrated segurity=true";
        }
        protected SqlConnection GetConexion()
        {
            return new SqlConnection(ConexionString);
        }

    }
}
