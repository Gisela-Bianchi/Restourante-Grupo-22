using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Trabajo_Final
{
    public partial class AdministradorMesas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page.DataBind();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            
            Button btn=sender as Button;
            int n=Convert.ToInt32(btn.CommandArgument);
            Label1.Text = n.ToString(); 
        }
    }
}