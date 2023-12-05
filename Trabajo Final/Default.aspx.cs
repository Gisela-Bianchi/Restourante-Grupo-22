using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {   //modificado
            Usuario usuario = new Usuario();
            usuario.Email = TxtNombreUsuario.Text;
            usuario.Contraseña = TxtContraseña.Text;
            UsuarioNegocio us = new UsuarioNegocio();
            Usuario regUsuario = us.Loguear(usuario);
            if (regUsuario.Activo == true)
            {
                Session.Add("Usuario", regUsuario);
                if (regUsuario.TipoUsuario == "Gerente")
                {
                    GerenteNegocio gNegocio = new GerenteNegocio();
                    Gerente gerente = gNegocio.traerGerentePorId(regUsuario.Id);
                    Session.Add("Gerente", gerente);
                    Session.Add("TipoUsuario", "Gerente");
                    Response.Write("Botón Gerente clickeado. Redireccionando...");
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    MeseroNegocio mNegocio = new MeseroNegocio();
                    Mesero mesero = mNegocio.traerMeseroPorId(regUsuario.Id);
                    Session.Add("Mesero", mesero);
                    Session.Add("TipoUsuario", "Mesero");
                    Response.Write("Botón Mozo clickeado. Redireccionando...");
                    Response.Redirect("Home.aspx");
                }

            }
            else
            {
                TxtNombreUsuario.Text = "";
                TxtContraseña.Text = "";
            }
        }
    }
}////prueba