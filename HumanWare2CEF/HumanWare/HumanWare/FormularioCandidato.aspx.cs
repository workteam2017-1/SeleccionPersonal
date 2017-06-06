using System;
using Entidad;
using AccesoDatos;

namespace HumanWare.HumanWare
{
    public partial class FormularioCandidato : System.Web.UI.Page
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
            this.ddlJornada.Items.Add("Completa");
            this.ddlJornada.Items.Add("Parcial");

            this.RadioButton1.Checked = true;
            this.RadioButton6.Checked = true;
            this.RadioButton11.Checked = true;
            this.RadioButton16.Checked = true;
            this.RadioButton21.Checked = true;
            this.RadioButton26.Checked = true;
            this.RadioButton31.Checked = true;
            this.RadioButton36.Checked = true;
            this.RadioButton41.Checked = true;
            this.RadioButton46.Checked = true;

        }

        protected void OnClickEnviar(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("OnClick");

            try
            {
                Candidato candidato = new Candidato();
                candidato.IDCandidato = int.Parse( this.TextBoxCedula.Text);
                candidato.nombreApellidos = this.txtNombresAp.Text;
                candidato.email = this.txtEmail.Text;
                candidato.telefono = int.Parse(this.txtTelefono.Text);
                candidato.retribucionMin= int.Parse(this.txtRetribucionMin.Text);
                candidato.jornada = (this.ddlJornada.SelectedValue == "Completa") ? false : true;
                candidato.titulacion = this.txtTitulacion.Text;

                System.Web.UI.WebControls.RadioButton[] radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton1, this.RadioButton2, this.RadioButton3, this.RadioButton4, this.RadioButton5 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemEquipo = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton6, this.RadioButton7, this.RadioButton8, this.RadioButton9, this.RadioButton10 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemDecisiones = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton11, this.RadioButton12, this.RadioButton13, this.RadioButton14, this.RadioButton15 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemIngles = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton16, this.RadioButton17, this.RadioButton18, this.RadioButton19, this.RadioButton20 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemComunicacion = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton21, this.RadioButton22, this.RadioButton23, this.RadioButton24, this.RadioButton25 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemInformes= i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton26, this.RadioButton27, this.RadioButton28, this.RadioButton29, this.RadioButton30 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemPuntualidad = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton31, this.RadioButton32, this.RadioButton33, this.RadioButton34, this.RadioButton35 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemInformacion = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton36, this.RadioButton37, this.RadioButton38, this.RadioButton39, this.RadioButton40 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemDatos= i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton41, this.RadioButton42, this.RadioButton43, this.RadioButton44, this.RadioButton45 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemSoftware = i + 1;
                }

                radioButtons = new System.Web.UI.WebControls.RadioButton[] { this.RadioButton46, this.RadioButton47, this.RadioButton48, this.RadioButton49, this.RadioButton50 };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked)
                        candidato.ItemVender= i + 1;
                }

                ControlHumanWare control = new ControlHumanWare();
                control.IngresarCandidato(candidato);
                this.lblResultado.Text = "El candidato se ha ingresado exitosamente";

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

        }
    }
}