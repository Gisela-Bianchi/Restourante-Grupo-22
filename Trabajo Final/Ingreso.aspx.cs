using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //nuevo boton mozo
        protected void btnMozo_Click(object sender, EventArgs e)
        {
            if (Session["Usuario" ]!= null)
            {
                Session.Add("TipoUsuario", "Mozo");
                Response.Redirect("Gerente.aspx");
            }
        }
           //nuevo boton gerente
        protected void btnGerente_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Usuario regUsuario = (Usuario)Session["Usuario"];
                if (regUsuario.TipoUsuario == 2)
                {
                    Session.Add("TipoUsuario", "Gerente");
                    Response.Redirect("Gerente.aspx");
                }
            }
        }
    }
}