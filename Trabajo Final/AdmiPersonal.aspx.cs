using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Trabajo_Final
{
    public partial class AdmiPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MeseroNegocio mNegocio = new MeseroNegocio();
            rptMeseros.DataSource = mNegocio.Listar();
            rptMeseros.DataBind();

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarMozo.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMozo.aspx");
        }

        protected string ConcatenarMesas(object value)
        {
            if (value != null)
            {
                List<int> mesas = (List<int>)value;
                string numerosConcatenados = string.Join(" - ", mesas);
                return numerosConcatenados;
            }
            return string.Empty;
        }

        protected void rptMeseros_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "editar")
            {
                string dni=e.CommandArgument.ToString();
                Session.Add("DNIeditar", dni);
                btnEditar_Click(source,e);
            }
            if (e.CommandName == "eliminar")
            {
                string dni = e.CommandArgument.ToString();
                Session.Add("DNIeliminar", dni);
               btnEliminar_Click(source, e);
            }
        }


    }
}