using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class ManejoErrores1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSinTryCatch_Click(object sender, EventArgs e)
        {
            int numero1 = 10;
            int numero2 = 0;
            int resultado = numero1 / numero2;
        }

        protected void btnConTryCatxh_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = 10;
                int numero2 = 0;
                int resultado = numero1 / numero2;
            }
            catch (Exception Ex)
            {

                lblMensaje.Text = "Error Controlado: " + Ex.Message;
            }
        }

        protected void btnErrorRecursoNoEncontrado_Click(object sender, EventArgs e)
        {
            Response.Redirect("pepe");
        }
    }
}