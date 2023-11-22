using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class MeserosActivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MeseroNegocio mesero = new MeseroNegocio();
            dgvMeseros.DataSource = mesero.Listar();
            dgvMeseros.DataBind();
        }
    }
    
}