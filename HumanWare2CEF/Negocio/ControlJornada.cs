using AccesoDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class ControlJornada
    {
        public BindingList<JornadaL> ObtenerJornadas()
        {
            AccesosDatosJornada accesoDatosJornada = new AccesosDatosJornada();
            return accesoDatosJornada.ObtenerJornadas();
        }
    }
}
