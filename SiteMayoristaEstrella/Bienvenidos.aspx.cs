using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMayoristaEstrella
{
    public partial class Bienvenidos : System.Web.UI.Page
    {
        int contador = 0;
        int contador2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //  txtNombre.Text = string.Empty;
            //   contador = (int)Session["contador"];
            if (!Page.IsPostBack)
            {
                if (Session["contador"] == null)
                {
                    Session["contador"] = contador;
                }
              
                if (Application["contador"] == null)
                {
                    Application["contador"] = contador2;
                }
              
            }


        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Response.Write("Hola Mundo");
            Response.Write("Mi nombre es " + txtNombre.Text);
          //  if (Session["contador"] == null)
          //  {
          //      Session["Contador"] = contador;
          //  }
            contador = (int)Session["contador"];
            contador2 = (int)Application["contador"];
            contador++;
            contador2++;
            Response.Write("Contador session " + contador);
            Response.Write("Contador aplicacion " + contador2);
            Session["contador"] = contador;
            Application["contador"] = contador2;


        }
    }
}