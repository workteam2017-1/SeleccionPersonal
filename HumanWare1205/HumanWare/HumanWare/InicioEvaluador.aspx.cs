using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanWare.HumanWare
{
    public partial class InicioEvaluador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickOferta1(object sender, EventArgs e)
        {
            Response.Redirect("~/HumanWare/EvaluadorOferta1");
        }

        protected void OnClickOferta2(object sender, EventArgs e)
        {
            Response.Redirect("~/HumanWare/EvaluadorOferta2");
        }
    }
}