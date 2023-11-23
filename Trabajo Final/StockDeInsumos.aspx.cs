using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Trabajo_Final
{
    public partial class Insumos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InsumoNegocio negocio = new InsumoNegocio();
            dgvInsumos.DataSource = negocio.Listar();
            dgvInsumos.DataBind();
        }

        protected void dgvInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvInsumos.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioStock.aspx?id=" + id);
        }

        protected void dgvInsumos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvInsumos.PageIndex = e.NewPageIndex;
            dgvInsumos.DataBind();
        }
    }
}