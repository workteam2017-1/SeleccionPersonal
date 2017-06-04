using AccesoDatos;
using Entidad;
using System;
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
            if (!this.IsPostBack)
            {
                this.CargarListas();
            }
        }

        private void CargarListas()
        {
            this.ddlJornadaEmp.Items.Add("Completa");
            this.ddlJornadaEmp.Items.Add("Parcial");
        }

        protected void OnClickPublicar(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("OnClick");

            try
            {
                System.Diagnostics.Debug.WriteLine("Try");

                OfertaVacante vacante = new OfertaVacante();
                //vacante.IDCandidato = int.Parse(this.TextBoxCedula.Text);
                vacante.empresa = this.txtNombreEmp.Text;
                vacante.telefonoEmpresa = int.Parse(this.txtTelEmpresa.Text);
                vacante.nombrePuesto = this.txtNombrePuesto.Text;
                vacante.descripcion = this.txtDescPuesto.Text;
                vacante.rangoMin = int.Parse(this.txtRangoSalario1.Text);
                vacante.rangoMax= int.Parse(this.txtRangoSalario2.Text);
                vacante.jornada = (this.ddlJornadaEmp.SelectedValue == "Completa") ? false : true;
                vacante.titulacion = this.txtTitulacion.Text;

                System.Web.UI.WebControls.RadioButton[] radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton1, this.RadioButton2, this.RadioButton3, this.RadioButton4, this.RadioButton5 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemEquipo = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton6, this.RadioButton7, this.RadioButton8, this.RadioButton9, this.RadioButton10 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemDecisiones = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton11, this.RadioButton12, this.RadioButton13, this.RadioButton14, this.RadioButton15 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemIngles = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton16, this.RadioButton17, this.RadioButton18, this.RadioButton19, this.RadioButton20 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemComunicacion = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton21, this.RadioButton22, this.RadioButton23, this.RadioButton24, this.RadioButton25 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemInformes = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton26, this.RadioButton27, this.RadioButton28, this.RadioButton29, this.RadioButton30 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemPuntualidad = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton31, this.RadioButton32, this.RadioButton33, this.RadioButton34, this.RadioButton35 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemInformacion = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton36, this.RadioButton37, this.RadioButton38, this.RadioButton39, this.RadioButton40 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemDatos = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton41, this.RadioButton42, this.RadioButton43, this.RadioButton44, this.RadioButton45 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemSoftware = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton46, this.RadioButton47, this.RadioButton48, this.RadioButton49, this.RadioButton50 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        vacante.ItemVender = i + 1;
                }

                ControlHumanWare control = new ControlHumanWare();
                control.IngresarVacante(vacante);
                this.lblResultado.Text = "La Oferta se ha ingresado exitosamente";

                //int contador = 0;
                //if(this.Application["Contador"] !=null)
                //{
                //    contador = (int)this.Application["Contador"];
                //}
                //this.Application["Contador"] = ++contador;
                ////if(!string.IsNullOrEmpty(this.Contador.Value))
                ////{
                ////    contador = int.Parse(this.Contador.Value);
                ////}
                ////this.Contador.Value = (++contador).ToString();
                //this.lblResultado.Text = "El contador es " + contador;

                //Response.Redirect("/Default");
            }
            catch (Exception Exc)
            {
                this.lblResultado.Text = "Error al ingresar el candidato" + Exc.Message;
            }

            System.Diagnostics.Debug.WriteLine("Exit");

        }

    }
}