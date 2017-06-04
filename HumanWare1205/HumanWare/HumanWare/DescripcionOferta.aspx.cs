using AccesoDatos;
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
            if (!this.IsPostBack)
            {
                this.CargarListas();
            }

            if (AccesoDatosHumanWare.vacanteActual != null)
            {
                txtNombrePuesto.Text = AccesoDatosHumanWare.vacanteActual.nombrePuesto;
                txtDescPuesto.Text = AccesoDatosHumanWare.vacanteActual.descripcion;
                txtRangoSalarial1.Text = AccesoDatosHumanWare.vacanteActual.rangoMin.ToString();
                txtRangoSalarial2.Text = AccesoDatosHumanWare.vacanteActual.rangoMax.ToString();
                ddlJornada.SelectedIndex = (AccesoDatosHumanWare.vacanteActual.jornada == false) ? 0 : 1;
                txtTitulacionReq.Text = AccesoDatosHumanWare.vacanteActual.titulacion;

                System.Web.UI.WebControls.RadioButton[] radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton1, this.RadioButton2, this.RadioButton3, this.RadioButton4, this.RadioButton5 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemEquipo - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton6, this.RadioButton7, this.RadioButton8, this.RadioButton9, this.RadioButton10 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemDecisiones - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton11, this.RadioButton12, this.RadioButton13, this.RadioButton14, this.RadioButton15 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemIngles - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton16, this.RadioButton17, this.RadioButton18, this.RadioButton19, this.RadioButton20 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemComunicacion - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton21, this.RadioButton22, this.RadioButton23, this.RadioButton24, this.RadioButton25 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemInformes - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton26, this.RadioButton27, this.RadioButton28, this.RadioButton29, this.RadioButton30 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemPuntualidad - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton31, this.RadioButton32, this.RadioButton33, this.RadioButton34, this.RadioButton35 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemInformacion - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton36, this.RadioButton37, this.RadioButton38, this.RadioButton39, this.RadioButton40 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemDatos - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton41, this.RadioButton42, this.RadioButton43, this.RadioButton44, this.RadioButton45 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemSoftware - 1].Checked = true;

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton46, this.RadioButton47, this.RadioButton48, this.RadioButton49, this.RadioButton50 };
                radioButtons[AccesoDatosHumanWare.vacanteActual.ItemVender - 1].Checked = true;

                btnAplicar.Enabled = true;
            }
            else
            {
                txtNombrePuesto.Text = "";
                txtDescPuesto.Text = "";
                txtRangoSalarial1.Text = "";
                txtRangoSalarial2.Text = "";
                ddlJornada.SelectedIndex = 0;
                txtTitulacionReq.Text = "";
                btnAplicar.Enabled = false;
            }

        }

        private void CargarListas()
        {
            this.ddlJornada.Items.Add("Completa");
            this.ddlJornada.Items.Add("Parcial");
        }

        protected void OnClickAplicar(object sender, EventArgs e)
        {
            Response.Redirect("/HumanWare/FormularioCandidato");
        }
    }
}