using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Trabajo_Final
{
    public partial class AgregarMozo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregarMozo_Click(object sender, EventArgs e)
        {
            Mesero mesero = new Mesero();
            MeseroNegocio meseroNegocio = new MeseroNegocio();
            Usuario usuario = new Usuario();
            mesero.ApellidoMesero = txtApellido.Text;
            mesero.NombreMesero = txtNombre.Text;
            mesero.DNI = int.Parse(txtDNI.Text);
            usuario.Email = txtEmail.Text;
            usuario.TipoUsuario = txtTipoUsuario.Text;
            usuario.Contraseña = txtContra.Text;

            try
            {
                meseroNegocio.AgregarMesero(mesero, usuario);
                Response.Redirect("AdmiPersonal.aspx");
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
    }
}