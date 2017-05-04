using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanWare.HumanWare
{
    public partial class DescripcionOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickAplicar(object sender, EventArgs e)
        {
            Response.Redirect("/HumanWare/FormularioCandidato");
        }
    }
}