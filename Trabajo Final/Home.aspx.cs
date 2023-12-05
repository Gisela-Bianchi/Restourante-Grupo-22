using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"] == null)
                {
                    Session.Add("error", "Debes Loguearte para ingresar");
                    Response.Redirect("Error.aspx");
                }
                else
                {

                    CargarPerfil();


                }

            }
            catch (Exception ex)
            {
                Session.Add("error", "Error durante la verificación de la sesión: " + ex.Message);
                Response.Redirect("Error.aspx");
            }


        }

        private void CargarPerfil()
        {
            Usuario usuario = (Usuario)Session["Usuario"];
            if ((string)Session["TipoUsuario"] == "Gerente")
            {
                Gerente gerente = (Gerente)Session["Gerente"];
                txtApellido.Text = gerente.ApellidoGerente;
                txtNombre.Text = gerente.NombreGerente;
                txtDNI.Text = gerente.DNI.ToString();
                txtEmail.Text = usuario.Email;
                txtTipoUsuario.Text = usuario.TipoUsuario;
            }
            else
            {
                Mesero mesero = (Mesero)Session["Mesero"];
                txtApellido.Text = mesero.ApellidoMesero;
                txtNombre.Text = mesero.NombreMesero;
                txtDNI.Text = mesero.DNI.ToString();
                txtEmail.Text = usuario.Email;
                txtTipoUsuario.Text = usuario.TipoUsuario;

            }


        }


    }
}