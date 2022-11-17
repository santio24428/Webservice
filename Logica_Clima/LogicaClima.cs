using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos_Clima;

namespace Logica_Clima
{
    public class ObtenerDatosClima
    {
        static ObtenerDatosClima _intancia = null;

        public static ObtenerDatosClima Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new ObtenerDatosClima();
            }
            return _intancia;
        }

        public T_CLIMA Obtener(int idclima)
        {
            return Datos_Clima.ObtenerDatosClima.Instancia().Obtener(idclima);
        }
    }

    public class ObtenerListaDatosClima
    {
        static ObtenerListaDatosClima _intancia = null;

        public static ObtenerListaDatosClima Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new ObtenerListaDatosClima();
            }
            return _intancia;
        }

        public List<T_CLIMA> Obtener()
        {
            return Datos_Clima.ObtenerListaDatosClima.Instancia().Obtener();
        }
    }

    public class ActualizarDatosClima
    {
        static ActualizarDatosClima _intancia = null;

        public static ActualizarDatosClima Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new ActualizarDatosClima();
            }
            return _intancia;
        }

        public bool Actualizar(T_CLIMA ObjClima)
        {
            return Datos_Clima.ActualizarDatosClima.Instancia().Actualizar(ObjClima);
        }
    }

    public class AgregarDatosClima
    {
        static AgregarDatosClima _intancia = null;

        public static AgregarDatosClima Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new AgregarDatosClima();
            }
            return _intancia;
        }

        public bool Agregar(T_CLIMA ObjClima)
        {
            return Datos_Clima.AgregarDatosClima.Instancia().Agregar(ObjClima);
        }
    }

    public class EliminarDatosClima
    {
        static EliminarDatosClima _intancia = null;

        public static EliminarDatosClima Instancia()
        {
            if (_intancia == null)
            {
                _intancia = new EliminarDatosClima();
            }
            return _intancia;
        }

        public bool Eliminar(int Idclima)
        {
            return Datos_Clima.EliminarDatosClima.Instancia().Eliminar(Idclima);
        }
    }

}
