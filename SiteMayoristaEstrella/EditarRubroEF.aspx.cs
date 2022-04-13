using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObjetosDeNegocio;
using Bussiness;

namespace SiteMayoristaEstrella
{
    public partial class EditarRubroEF : System.Web.UI.Page
    {
        int RubroId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["rubroid"] != "")
                RubroId = Convert.ToInt16(Request.QueryString["rubroid"]);
            else
                Response.Redirect("ListadoRubrosEF.aspx");

            if (!IsPostBack)
            {
                FillRubroData();
            }
        }


        private void FillRubroData()
        {
            Rubro rubro = RubroBussiness_EF.GetRubro(RubroId);
            txtDescripcion.Text = rubro.DescripcionRubro;
            Session["Rubro"] = rubro;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int RubroId = 0;
            Rubro r = (Rubro)Session["Rubro"];
            r.DescripcionRubro = txtDescripcion.Text;

            RubroId = RubroBussiness_EF.UpdateRubro(r);
            Response.Redirect("ListadoRubrosEF.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoRubrosEF.aspx");
        }
    }
}