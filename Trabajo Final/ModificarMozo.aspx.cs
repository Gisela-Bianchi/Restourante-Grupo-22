using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Trabajo_Final
{
    public partial class ModificarMozo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnModificarMozo_Click(object sender, EventArgs e)
        {
         UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            int id = usuarioNegocio.traerIDusuario(Session["DNIeditar"].ToString());

            if (id == -1)
            {
                return;
            }
        }
    }
}