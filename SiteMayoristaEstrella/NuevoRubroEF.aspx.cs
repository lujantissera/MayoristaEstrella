﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObjetosDeNegocio;
using Bussiness;

namespace SiteMayoristaEstrella
{
    public partial class NuevoRubroEF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int cliente = 0;
            Rubro r = new Rubro();
            r.DescripcionRubro = txtDescripcion.Text;

            cliente = RubroBussiness_EF.InsertRubro(r);
            Response.Redirect("ListadoRubrosEF.aspx");

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoRubrosEF.aspx");
        }
    }
}