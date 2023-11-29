using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Trabajo_Final
{
    public partial class Insumos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InsumoNegocio negocio = new InsumoNegocio();
            Session.Add("ListaInsumos", negocio.Listar());
            dgvInsumos.DataSource = Session["ListaInsumos"];
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

        protected void Filtro_TextChanged(object sender, EventArgs e)
        {
            List<Insumo> lista = (List<Insumo>)Session["ListaInsumos"];
            List<Insumo> listaFiltrada = lista.FindAll( x => x.NombreInsumo.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            dgvInsumos.DataSource = listaFiltrada;
            dgvInsumos.DataBind();
        }
    }
}