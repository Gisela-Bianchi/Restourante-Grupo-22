using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Trabajo_Final
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                PedidoNegocio pedN=new PedidoNegocio();
               List< int> numPedidos = pedN.NumerosPedidosDia();
                Session.Add("Cantidad de Pedidos", numPedidos);
            }
        }
    }
}