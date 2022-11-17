using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos_Clima;
using System.Data;
using Microsoft.SqlServer.Server;

namespace WebService_Prueba
{
    
    public partial class FrmInfoClima : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            btnGuardar.ValidationGroup = "Clima";
            if (!Page.IsPostBack)
            {
                CargarRejilla();
            }

        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInfoClima();
        }
        protected void gvrRejilla_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            hdfclimaID.Value = Convert.ToString(e.CommandArgument);
            switch (e.CommandName)
            {
                case "Seleccionar":
                    CargarDatoClima();
                    break;
                case "Eliminar":
                    ELiminarDatoClima();
                    break;
            }
        }


        #endregion



        #region Metodos
        public void CargarRejilla()
        {
            ServiceReferenceClima.WebService_ClimaSoapClient wsClima = new ServiceReferenceClima.WebService_ClimaSoapClient();
            var lis = wsClima.ObtenerListaDatosClima();
            gvrRejilla.DataSource = lis;
            gvrRejilla.DataBind();
        }

        public void LimpiarControles()
        {
            txtFecha.Text = DateTime.Now.ToString();
            txtCiudad.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtTemp.Text = string.Empty;
            hdfclimaID.Value = string.Empty;
            CargarRejilla();
        }

        public void GuardarInfoClima()
        {
            WebService_Prueba.ServiceReferenceClima.T_CLIMA Clima = new WebService_Prueba.ServiceReferenceClima.T_CLIMA();
            if (hdfclimaID.Value != string.Empty)
            {
                Clima.Id_CLIMA = Convert.ToInt16(hdfclimaID.Value);
            }
            Clima.IdUSUARIO_CLIMA = 0;
            Clima.FECHA_CLIMA = Convert.ToDateTime(txtFecha.Text);
            Clima.CIUDAD_CLIMA = txtCiudad.Text;
            Clima.ESTADO_CLIMA = txtEstado.Text;
            Clima.TEMPERATURA_CLIMA = Convert.ToByte(txtTemp.Text);
            ServiceReferenceClima.WebService_ClimaSoapClient wsClima = new ServiceReferenceClima.WebService_ClimaSoapClient();
            if (hdfclimaID.Value == string.Empty)
            {
                var resp = wsClima.AgregarDatosClima(Clima);
                if (resp == true)
                {
                    Response.Write("<script> alert('Se guardo correctamente.') </script>");
                }
                else
                {
                    Response.Write("<script> alert('Se a producido un error.') </script>");
                }
            }
            else
            {
                var resp = wsClima.ActualizarDatosClima(Clima);
                if (resp == true)
                {
                    Response.Write("<script> alert('Se actualizo correctamente.') </script>");
                }
                else
                {
                    Response.Write("<script> alert('Se a producido un error.') </script>");
                }
            }
            LimpiarControles();
        }

        public void CargarDatoClima()
        {
            ServiceReferenceClima.WebService_ClimaSoapClient wsClima = new ServiceReferenceClima.WebService_ClimaSoapClient();
            var dato = wsClima.ObtenerDatosClima(Convert.ToInt16(hdfclimaID.Value));
            string v = Convert.ToDateTime(dato.FECHA_CLIMA).ToString("yyyy-MM-dd");
            txtFecha.Text = v;
            txtCiudad.Text = dato.CIUDAD_CLIMA;
            txtEstado.Text = dato.ESTADO_CLIMA;
            txtTemp.Text = Convert.ToString(dato.TEMPERATURA_CLIMA);
        }

        public void ELiminarDatoClima()
        {
            ServiceReferenceClima.WebService_ClimaSoapClient wsClima = new ServiceReferenceClima.WebService_ClimaSoapClient();
            var resp = wsClima.EliminarDatosClima(Convert.ToInt16(hdfclimaID.Value));
            if (resp == true)
            {
                Response.Write("<script> alert('Se elimino correctamente.') </script>");
            }
            else
            {
                Response.Write("<script> alert('Se a producido un error.') </script>");
            }
            LimpiarControles();
        }

        #endregion

    }
}