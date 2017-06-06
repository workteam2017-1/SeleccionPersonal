using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanWare.HumanWare
{
    public partial class LoginAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickLoguearse(object sender, EventArgs e)
        {
            ControlSeguridadAdm control1 = new ControlSeguridadAdm();
            Administrador usuario1 = control1.ConsultarAdministrador(txtUsuario.Text);
            if (usuario1 != null)
            {
                if (control1.VerificarUsuario(usuario1, txtClave.Text))
                {
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                        txtUsuario.Text, DateTime.Now,
                        DateTime.Now.AddMinutes(30), true,
                        string.Empty,
                        FormsAuthentication.FormsCookiePath);
                    string hashCookies = FormsAuthentication.Encrypt(ticket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
                        hashCookies);
                    if (ticket.IsPersistent)
                    {
                        cookie.Expires = ticket.Expiration;
                    }
                    Response.Cookies.Add(cookie);
                    Response.Redirect("~/HumanWare/FormularioEmpresa");
                }
                else
                {
                    lblMensaje.Text = "Clave incorrecta";
                }
            }
            else
            {
                lblMensaje.Text = "Usuario incorrecto";
            }
           
        }
    }
}