using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesosDatosJornada
    {
        public BindingList<JornadaL> ObtenerJornadas()
        {
            HumanWareContext contexto = new HumanWareContext();
            BindingList<JornadaL> Jornadas= new BindingList<JornadaL>(contexto.Jornada.OrderBy(t => t.Nombre).ToList());

            return Jornadas;
        }

    }
}
