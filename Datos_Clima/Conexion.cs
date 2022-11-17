using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Datos_Clima
{
    public class Conexion
    {
        static Conexion _intancia = null;

        public static Conexion Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new Conexion();
            }
            return _intancia;
        }

        public IDbConnection GetConexionClima()
        {
            IDbConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbWS_ClimaEntities1"].ConnectionString);
            
            return db;
        }

        

    }
}
