using Bussiness;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace SiteMayoristaEstrella
{
    public partial class Rubros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillRubroGrid();
            }
        }

        private void FillRubroGrid()
        {

            List<Entidades.Rubro> RubroList = new List<Entidades.Rubro>();

            RubroBussiness RubroBiz = new RubroBussiness();

            RubroList = RubroBiz.GetRubros();

            gridRubrosList.DataSource = RubroList;

            gridRubrosList.DataBind();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in gridRubrosList.Rows)
            {
                row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference
                    (gridRubrosList, "Select$" + row.RowIndex.ToString(), true));
            }

            base.Render(writer);
        }
        protected void gridRubrosList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoRubro.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string RubroId = null;
            if (gridRubrosList.SelectedIndex != -1)
            {
                RubroId = gridRubrosList.SelectedRow.Cells[0].Text;
                Response.Redirect("EditarRubro.aspx?rubroid=" + RubroId);
            }
                
               
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int RubroId = 0;

            if (gridRubrosList.SelectedIndex != -1)
            {
                RubroId = Convert.ToInt32(gridRubrosList.SelectedRow.Cells[0].Text);
                RubroBussiness RubroBiz = new RubroBussiness();
                RubroBiz.DeleteRubro(RubroId);
                FillRubroGrid();
            }
        }
    }
}