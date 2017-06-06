using AccesoDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class ControlSeguridadAdm
    {
        public Administrador ConsultarAdministrador(string nombreUsuario)
        {
            AccesoDatosSeguridad accesoDatosSeguridad = new AccesoDatosSeguridad();
            return accesoDatosSeguridad.ConsultarAdministrador(nombreUsuario);
        }

        public bool VerificarUsuario(Administrador usuario1, string Contrasena)
        {
            return (usuario1 != null && usuario1.contrasena == Contrasena);
        }

        //public object usuario1 { get; set; }

        //public bool VerificarUsuario(global::HumanWare.HumanWare.LoginAdministrador usuario1, string p)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class ControlSeguridadEv
    {
        public Evaluador ConsultarEvaluador(string nombreUsuario)
        {
            AccesoDatosSeguridad accesoDatosSeguridad = new AccesoDatosSeguridad();
            return accesoDatosSeguridad.ConsultarEvaluador(nombreUsuario);
        }

        public bool VerificarUsuario(Evaluador usuario2, string Contrasena)
        {
            return (usuario2 != null && usuario2.contrasena == Contrasena);
        }
    }
}
