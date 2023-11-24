using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class FormularioCategoria : System.Web.UI.Page
    {
        public bool ConfirmarEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            ConfirmarEliminacion = false;

            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            if (id != "" && ! IsPostBack)
            {
                CategoriaNegocio categoria= new CategoriaNegocio();
                List<Categoria> lista= categoria.Listar(id);
                Categoria seleccionada = lista[0];


                //Cargamos los campos nuevamene modificados
                txtIdCategoria.Text = id;
                txtDescripcion.Text = seleccionada.Descripcion_Categoria;
            }


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Categoria categoria= new Categoria();

           
            categoria.Id_Categoria = int.Parse(txtIdCategoria.Text);
            categoria.Descripcion_Categoria = txtDescripcion.Text;


            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            if (Request.QueryString["id"] != null)
            {
                categoria.Id_Categoria = int.Parse(txtIdCategoria.Text);
                negocioCategoria.ModificarCategoria(categoria);

            }
            else
            {
                negocioCategoria.AgregarCategoria(categoria);


            }
            Response.Redirect("AdmiCategoria.aspx", false);

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmarEliminacion = true;
        }

        protected void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChkConfirmarEliminar.Checked)
                {
                    CategoriaNegocio categoria = new CategoriaNegocio();
                    categoria.EliminarCategoria(int.Parse(txtIdCategoria.Text));
                    Response.Redirect("AdmiCategoria.aspx", false);

                }
            }

            catch (Exception ex)
            {

                Session.Add("error", ex);
            }
        }
    }
}