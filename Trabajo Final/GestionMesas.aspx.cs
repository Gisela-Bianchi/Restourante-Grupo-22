using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class GestionMesas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminarMesa1_Click(object sender, EventArgs e)
        {
            Session.Add("MostrarMesa1", true);
        }
        protected void btnEliminarMesa2_Click(object sender, EventArgs e)
        {
            Session.Add("MostrarMesa2", true);
        }
        protected void btnEliminarMesa3_Click(object sender, EventArgs e)
        {
            Session.Add("MostrarMesa3", true);
        }
        protected void btnEliminarMesa4_Click(object sender, EventArgs e)
        {
            Session.Add("MostrarMesa4", true);
        }
        protected void btnEliminarMesa5_Click(object sender, EventArgs e)
        {
            Session.Add("MostrarMesa5", true);
        }
        protected void btnEliminarMesa6_Click(object sender, EventArgs e)
        {
            Session.Add("MostrarMesa6", true);
        }

        protected void btnAgregarMesa1_Click(object sender, EventArgs e)
        {
            Session["MostrarMesa1"] = null;
        }
        protected void btnAgregarMesa2_Click(object sender, EventArgs e)
        {
            Session["MostrarMesa2"] = null;
        }
        protected void btnAgregarMesa3_Click(object sender, EventArgs e)
        {
            Session["MostrarMesa3"] = null;
        }
        protected void btnAgregarMesa4_Click(object sender, EventArgs e)
        {
            Session["MostrarMesa4"] = null;
        }
        protected void btnAgregarMesa5_Click(object sender, EventArgs e)
        {
            Session["MostrarMesa5"] = null;
        }
        protected void btnAgregarMesa6_Click(object sender, EventArgs e)
        {
            Session["MostrarMesa6"] = null;
        }
    }
}