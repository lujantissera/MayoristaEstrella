using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;
using ObjetosDeNegocio;
namespace SiteMayoristaEstrella
{
    public partial class ListadoRubrosEF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetRubros();

            }
        }

        private void GetRubros()
        {
            // Variable para almacenar la lista de objetos
            var ProbarLista = new List<Rubro>();
            // Variables para realizar paginado de la grilla
            var paginaActual = this.grdListadoRubros.PageCount;

           
            var itemsXPagina = grdListadoRubros.PageSize;
            // Recuperación de la lista de objetos llamando a lógica de negocios
            // con parámetros de paginado
            ProbarLista = Bussiness.RubroBussiness_EF.ListRubros(paginaActual, itemsXPagina);
            // Asignación de la lista de objetos a la grilla
            grdListadoRubros.DataSource = ProbarLista;
            grdListadoRubros.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoRubroEF.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string RubroId = null;
            if (grdListadoRubros.SelectedIndex != -1)
            { 
                RubroId = grdListadoRubros.SelectedRow.Cells[0].Text;
                Response.Redirect("EditarRubroEF.aspx?rubroid=" + RubroId);
           }
        }
        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in grdListadoRubros.Rows)
            {
                row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference
                    (grdListadoRubros, "Select$" + row.RowIndex.ToString(), true));
            }

            base.Render(writer);
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string RubroId = null;
            if (grdListadoRubros.SelectedIndex != -1)
            {
                RubroId = grdListadoRubros.SelectedRow.Cells[0].Text;

                RubroBussiness_EF.DeleteRubro(int.Parse(RubroId));

                GetRubros();

            }
                
               
        }

        protected void grdListadoRubros_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }
    }
}