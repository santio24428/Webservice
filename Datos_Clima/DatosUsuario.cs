using Datos_Clima;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Data.EntityClient;



namespace Datos_Clima
{
    public class ObtenerUsuxLogin
    {
        static ObtenerUsuxLogin _intancia = null;

        public static ObtenerUsuxLogin Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new ObtenerUsuxLogin();
            }
            return _intancia;
        }

        public T_USUARIOS Obtener(string usuario, string clave)
        {
            using (dbWS_ClimaEntities1 contexto = new dbWS_ClimaEntities1())
            {
                T_USUARIOS usu = (from a  in contexto.T_USUARIOS where a.NOMBRE_USUARIO == usuario && a.CLAVE_USUARIO == clave select a ).FirstOrDefault();
                if (usu != null)
                {
                    return usu;
                }
                else
                {
                    return null;
                }
            }
          
        }
    }
}

