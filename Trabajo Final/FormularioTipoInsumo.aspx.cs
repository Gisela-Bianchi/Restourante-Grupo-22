using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class FormularioTipoDeInsumo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            if (id != "" && !IsPostBack)
            {
                TipoInsumoNegocio tipo = new TipoInsumoNegocio();
                List<TipoInsumo> lista = tipo.Listar(id);
                TipoInsumo seleccionada = lista[0];


                //Cargamos los campos nuevamene modificados
                txtIdTipoInsumo.Text = id;
                //txtNombreTipo.Text = seleccionada.NombreTipoInsumo;
                txtDescripcionTipo.Text = seleccionada.DescripcionTipoInsumo;
               //txtEstado.Text = seleccionada.EstadoTipoInsumo.ToString();

            }
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            TipoInsumo Tipo = new TipoInsumo();


            Tipo.Id_TI = int.Parse(txtIdTipoInsumo.Text);
            //Tipo.NombreTipoInsumo = txtNombreTipo.Text;
            Tipo.DescripcionTipoInsumo= txtDescripcionTipo.Text;
            Tipo.EstadoTipoInsumo = true;

          


            TipoInsumoNegocio TipoNegocio = new TipoInsumoNegocio();
            if (Request.QueryString["id"] != null)
            {
                Tipo.Id_TI = int.Parse(txtIdTipoInsumo.Text);
                TipoNegocio.MofidicarTipoInsumo(Tipo);

            }
            else
            {
                TipoNegocio.AgregarTipoInsumo(Tipo);

            }
            Response.Redirect("AdmiCategoria.aspx", false);
        }
    }
}