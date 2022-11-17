using Datos_Clima;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;



namespace Datos_Clima
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
            using (var contexto = new dbWS_ClimaEntities1())
            {
                T_CLIMA clima = (from a  in contexto.T_CLIMA where a.Id_CLIMA == idclima select a ).FirstOrDefault();
                return clima;
            }
          
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
            using (var contexto = new dbWS_ClimaEntities1())
            {
                List<T_CLIMA> clima = (from a in contexto.T_CLIMA select a).ToList();
                return clima;
            }

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
            try
            {
                using (var contexto = new dbWS_ClimaEntities1())
                {
                    var idclima = ObjClima.Id_CLIMA;
                    T_CLIMA clima = (from a in contexto.T_CLIMA where a.Id_CLIMA == idclima select a).FirstOrDefault();
                    if (clima != null)
                    { 
                        clima.ESTADO_CLIMA = ObjClima.ESTADO_CLIMA;
                        clima.FECHA_CLIMA = ObjClima.FECHA_CLIMA;
                        clima.CIUDAD_CLIMA = ObjClima.CIUDAD_CLIMA;
                        clima.TEMPERATURA_CLIMA = ObjClima.TEMPERATURA_CLIMA;
                        contexto.T_CLIMA.AddOrUpdate(clima);
                        contexto.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex) 
            { 
                throw new Exception("Error al actualizar el clima!. Error Interno " + ex.Message);
            }
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
            try
            {
                using (var contexto = new dbWS_ClimaEntities1())
                {
                    var idclima = ObjClima.Id_CLIMA;
                    T_CLIMA clima = (from a in contexto.T_CLIMA where a.Id_CLIMA == idclima select a).FirstOrDefault();
                    if (clima == null)
                    {
                        clima = new T_CLIMA();
                        clima.ESTADO_CLIMA = ObjClima.ESTADO_CLIMA;
                        clima.FECHA_CLIMA = ObjClima.FECHA_CLIMA;
                        clima.CIUDAD_CLIMA = ObjClima.CIUDAD_CLIMA;
                        clima.TEMPERATURA_CLIMA = ObjClima.TEMPERATURA_CLIMA;
                        clima.IdUSUARIO_CLIMA = ObjClima.IdUSUARIO_CLIMA;
                        contexto.T_CLIMA.Add(clima);
                        contexto.SaveChanges();
                        return true;
                    }
                    else
                    { 
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el clima!. Error Interno " + ex.Message);
            }
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
            try
            {
                using (var contexto = new dbWS_ClimaEntities1())
                {
                    T_CLIMA clima = (from a in contexto.T_CLIMA where a.Id_CLIMA == Idclima select a).FirstOrDefault();
                    if (clima != null)
                    {
                        contexto.T_CLIMA.Remove(clima);
                        contexto.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el clima!. Error Interno " + ex.Message);
            }
        }
    }
}

