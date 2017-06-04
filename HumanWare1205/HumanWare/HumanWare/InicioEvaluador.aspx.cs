using AccesoDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            HumanWareContext context = new HumanWareContext();
            foreach (var oferta in context.Oferta)
            {
                Literal literalAux = new Literal();
                literalAux.Text = "<tr>";
                ButtonsPlaceHolder.Controls.Add(literalAux);

                literalAux = new Literal();
                literalAux.Text = "<td align = \"center\" >" + " " + oferta.empresa + "</td>";
                 ButtonsPlaceHolder.Controls.Add(literalAux);

                literalAux = new Literal();
                literalAux.Text = "<td align = \"center\" style = \"height: 46px\">";
                ButtonsPlaceHolder.Controls.Add(literalAux);

                Button buttonAux = new Button();
                buttonAux.ID = oferta.IDVacante.ToString();
                buttonAux.Text = oferta.nombrePuesto;
                buttonAux.Click += OnClickOferta;
                ButtonsPlaceHolder.Controls.Add(buttonAux);
                System.Diagnostics.Debug.WriteLine((buttonAux).ID);
                ButtonsPlaceHolder.Controls.Add(buttonAux);

                literalAux = new Literal();
                literalAux.Text = "</td>";
                ButtonsPlaceHolder.Controls.Add(literalAux);

                literalAux = new Literal();
                literalAux.Text = "</tr>";
                ButtonsPlaceHolder.Controls.Add(literalAux);
            }
        }

        protected void OnClickOferta(object sender, EventArgs e)
        {
            ControlHumanWare control = new ControlHumanWare();
            control.SetVacanteActual(int.Parse((sender as Button).ID));
            Response.Redirect("~/HumanWare/EvaluadorOferta");
        }
    }
}