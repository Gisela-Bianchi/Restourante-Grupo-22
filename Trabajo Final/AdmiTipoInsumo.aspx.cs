using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class AdmiTipoInsumo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoInsumoNegocio Tipo = new TipoInsumoNegocio();
            dgvTipoInsumo.DataSource = Tipo.Listar();
            dgvTipoInsumo.DataBind();
        }

        protected void dgvTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = dgvTipoInsumo.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioTipoInsumo.aspx?id=" + id);
        }

        protected void dgvTipoInsumo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvTipoInsumo.PageIndex = e.NewPageIndex;
            dgvTipoInsumo.DataBind();
        }
    }
}