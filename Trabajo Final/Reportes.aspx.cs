using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Trabajo_Final
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ReporteNegocio reporteNegocio = new ReporteNegocio();
                ddlMesas.DataSource = reporteNegocio.todosNumMesa();
                ddlMesas.DataBind();
            }
        }

        protected void ddlMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mesaSeleccionada=ddlMesas.SelectedValue;
            lblrecaudacionTotal.Text = mesaSeleccionada;
            string[] separacion = new string[2];
            separacion=mesaSeleccionada.Split(' ');
            ReporteNegocio reNeg=new ReporteNegocio();
           decimal recaudacionTot= reNeg.recTotXMesa(Convert.ToInt32(separacion[1]));
            lblrecaudacionTotal.Text = $"El total recaudado de la mesa {separacion[1]} es: {recaudacionTot}";
        }
    }
}