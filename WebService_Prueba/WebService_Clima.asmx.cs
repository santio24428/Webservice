using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica_Clima;
using Datos_Clima;

namespace WebService_Prueba
{
    /// <summary>
    /// Descripción breve de WebService_Clima
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_Clima : System.Web.Services.WebService
    {

        [WebMethod]
        public T_CLIMA ObtenerDatosClima(int idclima)
        {
            return Logica_Clima.ObtenerDatosClima.Instancia().Obtener(idclima);
        }

        [WebMethod]
        public List<T_CLIMA> ObtenerListaDatosClima()
        {
            return Logica_Clima.ObtenerListaDatosClima.Instancia().Obtener();
        }

        [WebMethod]
        public bool ActualizarDatosClima(T_CLIMA ObjClima)
        {
            return Logica_Clima.ActualizarDatosClima.Instancia().Actualizar(ObjClima);
        }


        [WebMethod]
        public bool AgregarDatosClima(T_CLIMA ObjClima)
        {
            return Logica_Clima.AgregarDatosClima.Instancia().Agregar(ObjClima);
        }

        [WebMethod]
        public T_USUARIOS ObtenerUsuxLogin(string usuario, string clave)
        {
            return Logica_Clima.ObtenerUsuxLogin.Instancia().Obtener(usuario, clave);
        }

        [WebMethod]
        public bool EliminarDatosClima(int idclima)
        {
            return Logica_Clima.EliminarDatosClima.Instancia().Eliminar(idclima);
        }
    }
}
