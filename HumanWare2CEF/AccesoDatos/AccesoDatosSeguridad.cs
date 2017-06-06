using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoDatosSeguridad
    {
        private Administrador administradorActual;
        public Administrador ConsultarAdministrador(string nombreUsuario)
        {
            HumanWareContext context = new HumanWareContext();
            administradorActual = context.Administradores.FirstOrDefault(u => u.usuario.Equals(nombreUsuario) );
            return administradorActual;
        }

        private Evaluador evaluadorActual;
        public Evaluador ConsultarEvaluador(string nombreUsuario)
        {
            HumanWareContext context = new HumanWareContext();
            evaluadorActual = context.Evaluadores.FirstOrDefault(u => u.usuario.Equals(nombreUsuario));

            return evaluadorActual;
        }
    }
}
