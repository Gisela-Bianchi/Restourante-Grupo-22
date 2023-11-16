using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class AdmiCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategoria.DataSource = categoria.Listar();
            dgvCategoria.DataBind();
        }

        protected void dgvCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string id=dgvCategoria.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioCategoria.aspx?id="+ id);
        }

        protected void dgvCategoria_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvCategoria.PageIndex = e.NewPageIndex;
            dgvCategoria.DataBind();
        }
    }
}