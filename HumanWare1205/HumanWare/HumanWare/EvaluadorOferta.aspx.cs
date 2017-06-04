using AccesoDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanWare.HumanWare
{
    public partial class EvaluadorOferta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.CargarListas();
            }
        }

        string CalcularPuntajeCandidato(Candidato candidato)
        {
            int puntaje = candidato.ItemEquipo + candidato.ItemDecisiones + candidato.ItemIngles
                + candidato.ItemComunicacion + candidato.ItemInformes + candidato.ItemPuntualidad
                + candidato.ItemInformacion + candidato.ItemDatos + candidato.ItemSoftware + candidato.ItemVender;

            if (puntaje >= 45)
                return "C2";
            else if(puntaje >= 30)
                return "C1";
            else if (puntaje >= 20)
                return "B2";
            else
                return "B1";
        }

        private void CargarListas()
        {
            this.ddlJornada.Items.Add("Completa");
            this.ddlJornada.Items.Add("Parcial");

            if (AccesoDatosHumanWare.vacanteActual != null)
            {
                txtNombrePuesto.Text = AccesoDatosHumanWare.vacanteActual.nombrePuesto;
                txtDescPuesto.Text = AccesoDatosHumanWare.vacanteActual.descripcion;
                txtRangoSalarial1.Text = AccesoDatosHumanWare.vacanteActual.rangoMin.ToString();
                txtRangoSalarial2.Text = AccesoDatosHumanWare.vacanteActual.rangoMax.ToString();
                ddlJornada.SelectedIndex = (AccesoDatosHumanWare.vacanteActual.jornada == false) ? 0 : 1;
                txtTitulacionReq.Text = AccesoDatosHumanWare.vacanteActual.titulacion;

                HumanWareContext context = new HumanWareContext();
                var candidatoxOferta = context.CandidatoxOfertaVacante.
                Where<CandidatoxOfertaVacante>(p => p.IDVacante.Equals(AccesoDatosHumanWare.vacanteActual.IDVacante));

                //ControlPaciente control = new ControlPaciente();
                BindingList<Candidato> candidatosList = new BindingList<Candidato>();

                foreach (var listaCandidatos in candidatoxOferta)
                {
                    System.Diagnostics.Debug.WriteLine(listaCandidatos.IDCandidato + "   " + listaCandidatos.IDVacante);
                    int IDC = listaCandidatos.IDCandidato;
                    int IDV = listaCandidatos.IDVacante;

                    try
                    {
                        HumanWareContext contextCandidatos = new HumanWareContext();
                        Candidato candidato = contextCandidatos.Candidatos.
                        FirstOrDefault(p => p.IDCandidato.Equals(IDC));
                        System.Diagnostics.Debug.WriteLine(candidato.IDCandidato + "   " + candidato.nombreApellidos);

                        candidatosList.Add(candidato);

                        Literal literalAux = new Literal();
                        literalAux.Text = "<tr>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.nombreApellidos + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.titulacion + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.retribucionMin.ToString() + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + ((candidato.jornada == false) ? "Completa" : "Parcial") + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemEquipo + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemDecisiones + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemIngles + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemComunicacion + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemInformes + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemPuntualidad + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemInformacion + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemDatos + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemSoftware + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + candidato.ItemVender + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "<td align = \"center\" >" + " " + CalcularPuntajeCandidato(candidato) + "</td>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);

                        literalAux = new Literal();
                        literalAux.Text = "</tr>";
                        CandidatosPlaceHolder.Controls.Add(literalAux);


                    }
                    catch (Exception exce)
                    {
                        System.Diagnostics.Debug.WriteLine(exce.InnerException.Message);
                    }
                }

                this.Session["EvaluadorOferta"] = candidatosList;

                if (candidatosList.Count > 0)
                {
                    this.btnExportar.Enabled = true;
                }
                else
                {
                    this.btnExportar.Enabled = false;
                }

            }
            else
            {
                txtNombrePuesto.Text = "";
                txtDescPuesto.Text = "";
                txtRangoSalarial1.Text = "";
                txtRangoSalarial2.Text = "";
                ddlJornada.SelectedIndex = 0;
                txtTitulacionReq.Text = "";
            }
        }

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.Buffer = true;
            Response.ContentType = "application/excel";
            Response.AppendHeader("content-disposition", "attachment; filename=" + "ListadoCandidatos" + string.Format("{0:yyyyMMddHmmss}", DateTime.Now) + ".xls;");

            const string head = "<html><head><meta http-equiv='Content-Type' content='Text/Html; charset=UTF-8'></head><body><table>" +
                                     "<tr><td colspan='17'><strong><center>CANDIDATOS</center></strong></td></tr>";
            const string footer = "</table></body></html>";

            string encabezado = "<tr>" +
                   "<td><strong>Nombre</font></strong></td>" +
                   "<td><strong>Documento</font></strong></td>" +
                   "<td><strong>email</font></strong></td>" +
                   "<td><strong>jornada</font></strong></td>" +
                   "<td><strong>Retribución Mínima</font></strong></td>" +
                   "<td><strong>Telefono</font></strong></td>" +
                   "<td><strong>Titulación</font></strong></td>" +
                   "<td><strong>Comunicación</font></strong></td>" +
                   "<td><strong>Datos</font></strong></td>" +
                   "<td><strong>Decisiones</font></strong></td>" +
                   "<td><strong>Equipo</font></strong></td>" +
                   "<td><strong>Información</font></strong></td>" +
                   "<td><strong>Informes</font></strong></td>" +
                   "<td><strong>Inglés</font></strong></td>" +
                   "<td><strong>Puntualidad</font></strong></td>" +
                   "<td><strong>Software</font></strong></td>" +
                   "<td><strong>Vender</font></strong></td>" +
                    "</tr>";
            BindingList<Candidato> candidatosEnOferta = this.Session["EvaluadorOferta"] as BindingList<Candidato>;
            string detalle = string.Empty;
            foreach (Candidato candidato in candidatosEnOferta)
            {
                detalle += "<tr><td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.nombreApellidos)) + "</center></dt>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.IDCandidato)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(candidato.email) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode((candidato.jornada == false) ? "Completa" : "Parcial") + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.retribucionMin)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.telefono)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.titulacion)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemComunicacion)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemDatos)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemDecisiones)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemEquipo)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemInformacion)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemInformes)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemIngles)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemPuntualidad)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemSoftware)) + "</center></td>" +
                           "<td><center>" + WebUtility.HtmlEncode(Convert.ToString(candidato.ItemVender)) + "</center></td>" +
                           "</tr>";
            }

            var contenido = encabezado + detalle;
            Response.Write(head + contenido + footer);
        }

    }

}