﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanWare.HumanWare
{
    public partial class FormularioEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickPublicar(object sender, EventArgs e)
        {
            Response.Redirect("~/HumanWare/FormularioEmpresa");
        }
        
    }
}