using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos_Clima;

namespace Logica_Clima
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
            return Datos_Clima.ObtenerUsuxLogin.Instancia().Obtener(usuario, clave);
        }
    }
}
