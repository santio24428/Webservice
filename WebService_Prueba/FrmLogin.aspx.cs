using Datos_Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService_Prueba
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string clave = txtClave.Text;
            ServiceReferenceClima.WebService_ClimaSoapClient wsClima = new ServiceReferenceClima.WebService_ClimaSoapClient();
            var res = wsClima.ObtenerUsuxLogin(login, clave);
            if (res != null)
            {
                Response.Redirect("~/FrmInfoClima.aspx");
            }
            else
            {
                Response.Write("<script> alert(" + "'Datos Incorrectos!'" + ") </script>");
            }

        }
    }
}